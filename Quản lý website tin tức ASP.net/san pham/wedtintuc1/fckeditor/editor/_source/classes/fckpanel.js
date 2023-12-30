/*
 * FCKeditor - The text editor for internet
 * Copyright (C) 2003-2006 Frederico Caldeira Knabben
 * 
 * Licensed under the terms of the GNU Lesser General Public License:
 * 		http://www.opensource.org/licenses/lgpl-license.php
 * 
 * For further information visit:
 * 		http://www.fckeditor.net/
 * 
 * "Support Open Source software. What about a donation today?"
 * 
 * File Name: fckpanel.js
 * 	FCKPanel Class: component that creates floating panels. It is used by many 
 * 	other components, like the toolbar items, context menu, etc...
 * 
 * File Authors:
 * 		Frederico Caldeira Knabben (fredck@fckeditor.net)
 */

var FCKPanel = function( parentWindow, hideOnBlur )
{
	this.IsRTL			= ( FCKLang.Dir == 'rtl' ) ;
	this.IsContextMenu	= false ;
	this._IsOpened		= false ;
	this.HideOnBlur		= hideOnBlur ;
	this.CanHide		= hideOnBlur ;
	
	this._Window = parentWindow || window ;
	
	var oDocument ;
	
	if ( hideOnBlur && FCKBrowserInfo.IsIE )
	{
		// Create the Popup that will hold the panel.
		this._Popup	= this._Window.createPopup() ;
		oDocument = this.Document = this._Popup.document ;
	}
	else
	{
		var oIFrame = this._IFrame = this._Window.document.createElement('iframe') ; 
		oIFrame.allowTransparency	= true ;
		oIFrame.frameBorder			= '0' ;
		oIFrame.scrolling			= 'no' ;
		oIFrame.style.position		= 'absolute';
		oIFrame.style.zIndex		= FCKConfig.FloatingPanelsZIndex ;
		oIFrame.width = oIFrame.height = FCKBrowserInfo.IsIE ? 1 : 0 ;

		this._Window.document.body.appendChild( oIFrame ) ;
		
		var oIFrameWindow = oIFrame.contentWindow ; 
		
		oDocument = this.Document = oIFrameWindow.document ;

		// Initialize the IFRAME document body.
		oDocument.open() ;
		oDocument.write( '<html><head></head><body><\/body><\/html>' ) ;
		oDocument.close() ;

		// Remove the default margins.
		oDocument.body.style.margin = oDocument.body.style.padding = '0px' ;
		
		if ( hideOnBlur )
		{
			oIFrameWindow.Panel = this ;

			if ( FCKBrowserInfo.IsSafari )
				oIFrameWindow.IsFCKPanel = true ;
			else
			{
				oIFrameWindow.onfocus	= FCKPanel_Window_OnFocus ;
				oIFrameWindow.onblur	= FCKPanel_Window_OnBlur ;
			}
		}
	}

	oDocument.dir = FCKLang.Dir ;


	// Create the main DIV that is used as the panel base.
	this.MainNode = oDocument.body.appendChild( oDocument.createElement('DIV') ) ;

	// The "float" property must be set so Firefox calculates the size correcly.
	this.MainNode.style.cssFloat = this.IsRTL ? 'right' : 'left' ;
}

FCKPanel.prototype.EnableContextMenu = function( enabled )
{
	this.Document.oncontextmenu = enabled ? null : FCKTools.CancelEvent ;
}

FCKPanel.prototype.AppendStyleSheet = function( styleSheet )
{
	FCKTools.AppendStyleSheet( this.Document, styleSheet ) ;
}

FCKPanel.prototype.SetDirection = function( dir )
{
	this.IsRTL = ( dir == 'rtl' ) ;
	this.Document.dir = dir ;
}

FCKPanel.prototype.Load = function( x, y, relElement )
{
	// The offsetWidth and offsetHeight properties are not available if the 
	// element is not visible. So we must "show" the popup with no size to
	// be able to use that values in the second call (IE only).
	if ( this._Popup )
		this._Popup.show( x, y, 0, 0, relElement ) ;
}

FCKPanel.prototype.Show = function( x, y, relElement, width, height )
{
	if ( this._Popup )
	{
		// The offsetWidth and offsetHeight properties are not available if the 
		// element is not visible. So we must "show" the popup with no size to
		// be able to use that values in the second call.
		this._Popup.show( x, y, 0, 0, relElement ) ;

		// The following lines must be place after the above "show", otherwise it 
		// doesn't has the desired effect.
		this.MainNode.style.width	= width ? width + 'px' : '' ;
		this.MainNode.style.height	= height ? height + 'px' : '' ;
		
		var iMainWidth = this.MainNode.offsetWidth ;

		if ( this.IsRTL )
		{
			if ( this.IsContextMenu )
				x  = x - iMainWidth + 1 ;
			else if ( relElement )
				x  = ( x * -1 ) + relElement.offsetWidth - iMainWidth ;
		}
	
		// Second call: Show the Popup at the specified location, with the correct size.
		this._Popup.show( x, y, iMainWidth, this.MainNode.offsetHeight, relElement ) ;
		
		if ( this.OnHide )
		{
			if ( FCKPanel_ActivePopupInfo.Timer )
				CheckPopupOnHide() ;
			FCKPanel_ActivePopupInfo.Timer = window.setInterval( CheckPopupOnHide, 100 ) ;
			FCKPanel_ActivePopupInfo.Panel = this ;
		}
	}
	else
	{
		FCKFocusManager.Lock() ;
		
		this.MainNode.style.width	= width ? width + 'px' : '' ;
		this.MainNode.style.height	= height ? height + 'px' : '' ;

		var iMainWidth = this.MainNode.offsetWidth ;

		if ( !width )	this._IFrame.width	= 1 ;
		if ( !height )	this._IFrame.height	= 1 ;

		var oPos ;
		
		if ( relElement.nodeType == 9 )
			oPos = FCKTools.GetElementPosition( relElement.body, this._Window ) ;
		else
			oPos = FCKTools.GetElementPosition( relElement, this._Window ) ;

		if ( this.IsRTL && !this.IsContextMenu )
			x = ( x * -1 ) ;

		x += oPos.X ;
		y += oPos.Y ;

		if ( this.IsRTL )
		{
			if ( this.IsContextMenu )
				x  = x - iMainWidth + 1 ;
			else if ( relElement )
				x  = x + relElement.offsetWidth - iMainWidth ;
		}
		else
		{
			var oViewPaneSize = FCKTools.GetViewPaneSize( this._Window ) ;

			if ( ( x + iMainWidth ) > oViewPaneSize.Width )
				x -= x + iMainWidth - oViewPaneSize.Width ;

			if ( ( y + this.MainNode.offsetHeight ) > oViewPaneSize.Height )
				y -= y + this.MainNode.offsetHeight - oViewPaneSize.Height ;
		}
		
		if ( x < 0 )
			 x = 0 ;

		// Set the context menu DIV in the specified location.
		this._IFrame.style.left	= x + 'px' ;
		this._IFrame.style.top	= y + 'px' ;
		
		var iWidth	= iMainWidth ;
		var iHeight	= this.MainNode.offsetHeight ;
		
		if ( FCKBrowserInfo.IsSafari )
			FCKPanel_WatchOnDocumentClick( window.top ) ;
		
		this._IFrame.width	= iWidth ;
		this._IFrame.height = iHeight ;

		// Move the focus to the IFRAME so we catch the "onblur".
		this._IFrame.contentWindow.focus() ;
		
		this.HasFocus = true ;
	}

	if ( this.OnShow )
		this.OnShow.call( this ) ;

	this._IsOpened = true ;
}

FCKPanel.prototype.Hide = function( ignoreIfHasFocus )
{
	if ( this._Popup )
		this._Popup.hide() ;
	else
	{
		FCKFocusManager.Unlock() ;

		var oPanel = this.Panel || this ;

		if ( !oPanel._IsOpened || !oPanel.CanHide || ( ignoreIfHasFocus && oPanel.HasFocus ) )
			return ;
		
		// It is better to set the sizes to 0, otherwise Firefox would have 
		// rendering problems.
		oPanel._IFrame.width = oPanel._IFrame.height = FCKBrowserInfo.IsIE ? 1 : 0 ;

		if ( oPanel.OnHide )
			oPanel.OnHide.call( oPanel ) ;

		oPanel._IsOpened = false ;
	}
}

FCKPanel.prototype.CheckIsOpened = function()
{
	if ( this._Popup )
		return this._Popup.isOpen ;
	else
		return this._IsOpened ;
}

function FCKPanel_Window_OnFocus()
{
	var oPanel = this.Panel ;
	oPanel.HasFocus = true ;
}

function FCKPanel_Window_OnBlur( e )
{
	var oPanel = this.Panel ;
	oPanel.HasFocus = false ;
	
	FCKTools.RunFunction( oPanel.Hide, oPanel._IFrame.contentWindow ) ;
}

var FCKPanel_ActivePopupInfo = new Object() ;

function CheckPopupOnHide()
{
	var oPanel = FCKPanel_ActivePopupInfo.Panel ;
	
	if ( oPanel && !oPanel._Popup.isOpen )
	{
		window.clearInterval( FCKPanel_ActivePopupInfo.Timer ) ;
		
		if ( oPanel.OnHide )
			oPanel.OnHide.call( oPanel ) ;
		
		FCKPanel_ActivePopupInfo.Timer = null ;
		FCKPanel_ActivePopupInfo.Panel = null ;
	}
}

// Used just by Safari.

function FCKPanel_WatchOnDocumentClick( targetWindow )
{
	// Try/Catch must be used to avoit an error when using a frameset
	// on a different domain:
	// "Permission denied to get property Window.frameElement".
	try
	{
		if ( targetWindow == null || ( targetWindow.frameElement && targetWindow.frameElement.IsFCKPanel ) )
			return ;

		targetWindow.document.addEventListener( 'click', FCKPanel_OnDocumentClick, false ) ;
	}
	catch (e) {}

	for ( var i = 0 ; i < targetWindow.frames.length ; i++ )
		FCKPanel_WatchOnDocumentClick( targetWindow.frames[i] ) ;
}

// Used just by Safari.

function FCKPanel_OnDocumentClick( e )
{
	var oWindow = FCKTools.GetElementWindow( e.target ) ;

	if ( ! oWindow.IsFCKPanel )
	{
		function RemoveOnClickListener( targetWindow )
		{
			if ( targetWindow == null )
				return ;

			// Try/Catch must be used to avoit an error when using a frameset
			// on a different domain:
			// "Permission denied to get property Window.frameElement".
			try
			{
				if ( targetWindow.IsFCKPanel )
				{
					targetWindow.Panel.Hide() ;
					return ;
				}
				else
					targetWindow.document.removeEventListener( 'click', FCKPanelEventHandlers.OnDocumentClick, false ) ;
			}
			catch (e) {}

			for ( var i = 0 ; i < targetWindow.frames.length ; i++ )
				RemoveOnClickListener( targetWindow.frames[i] ) ;
		}
		RemoveOnClickListener( window.top ) ;
	}
}