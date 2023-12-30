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
 * File Name: fckfitwindow.js
 * 	Stretch the editor to full window size and back.
 * 
 * File Authors:
 * 		Paul Moers (mail@saulmade.nl)
 * 		Thanks to Christian Fecteau (webmaster@christianfecteau.com)
 * 		Frederico Caldeira Knabben (fredck@fckeditor.net)
 */

var FCKFitWindow = function()
{
	this.Name = 'FitWindow' ;
}

FCKFitWindow.prototype.Execute = function()
{
	var eEditorFrame		= window.frameElement ;
	var eEditorFrameStyle	= eEditorFrame.style ;

	var eMainWindow			= parent ;
	var eDocEl				= eMainWindow.document.documentElement ;
	var eBody				= eMainWindow.document.body ;
	var eBodyStyle			= eBody.style ;

	// No original style properties known? Go fullscreen.
	if ( this.originalCssText == null )
	{
		// Registering an event handler when the window gets resized.
		if( FCKBrowserInfo.IsIE )
			eMainWindow.attachEvent( 'onresize', FCKFitWindow_Resize ) ;
		else
			eMainWindow.addEventListener( 'resize', FCKFitWindow_Resize, true ) ;

		// Save the scrollbars position.
		this._ScrollPos = FCKTools.GetScrollPosition( eMainWindow ) ;
		
		// preparing the body for the editor in fullsize and hiding the scrollbars in Firefox
		this.bodyCssText	= eBodyStyle.cssText ;
		eBodyStyle.cssText	= '' ;
		eBodyStyle.overflow	= 'hidden' ;
		eBodyStyle.margin	= '0px' ;
		eBodyStyle.padding	= '0px' ;
		eBodyStyle.height	= '0px' ;
		eBodyStyle.width	= '0px' ;
		eBodyStyle.position	= 'static' ;
		eBodyStyle.top		= '0px' ;
		eBodyStyle.left		= '0px' ;

		// Save the body className.
		this.bodyClassName = eBody.className ;
		
		// Hide IE scrollbars (in strict mode).
		if ( FCKBrowserInfo.IsIE )
		{
			this.documentElementOverflow = eDocEl.style.overflow ;
			eDocEl.style.overflow = "hidden" ;
		}
		
		// Save some frame attributes.
		this.originalCssText	= eEditorFrameStyle.cssText;
		this.originalWidth		= eEditorFrame.width;
		this.originalHeight		= eEditorFrame.height;
		
		// Resize.
		var oViewPaneSize = FCKTools.GetViewPaneSize( eMainWindow ) ;

		eEditorFrameStyle.position	= "absolute";
		eEditorFrameStyle.zIndex	= FCKConfig.FloatingPanelsZIndex - 1;
		eEditorFrameStyle.left		= "0px";
		eEditorFrameStyle.top		= "0px";
		eEditorFrameStyle.width		= oViewPaneSize.Width + "px";
		eEditorFrameStyle.height	= oViewPaneSize.Height + "px";
		
		// Giving the frame some (huge) borders on his right and bottom
		// side to hide the background that would otherwise show when the
		// editor is in fullsize mode and the window is increased in size
		// not for IE, because IE immediately adapts the editor on resize, 
		// without showing any of the background oddly in firefox, the
		// editor seems not to fill the whole frame, so just setting the
		// background of it to white to cover the page laying behind it anyway.
		if ( !FCKBrowserInfo.IsIE )
		{
			eEditorFrameStyle.borderRight = eEditorFrameStyle.borderBottom = "9999px solid white" ;
			eEditorFrameStyle.backgroundColor		= "white";
		}

		// Scroll to top left.
		eMainWindow.scrollTo(0, 0);
	}
	else	// Resize to original size.
	{
		// Remove the event handler of window resizing.
		if( FCKBrowserInfo.IsIE )
			eMainWindow.detachEvent( "onresize", FCKFitWindow_Resize ) ;
		else
			eMainWindow.removeEventListener( "resize", FCKFitWindow_Resize, true ) ;

		// Restoring the body and restoring the scrollbars in Firefox.
		eBodyStyle.cssText = this.bodyCssText ;

		// Restore the className.
		eBody.className = this.bodyClassName ;

		// Restore IE scrollbars
		if ( FCKBrowserInfo.IsIE )
			eDocEl.style.overflow = this.documentElementOverflow ;

		// Restore original size
		with ( eEditorFrameStyle )
		{
			cssText		= this.originalCssText;
			width		= this.originalWidth;
			height		= this.originalHeight;
			position	= "static";
		}
		
		// Restore the window scroll position.
		eMainWindow.scrollTo( this._ScrollPos.X, this._ScrollPos.Y ) ;

		// Clear the CSS buffer.
		this.originalCssText = null ;
	}
	
	FCKToolbarItems.GetItem('FitWindow').RefreshState() ;
	
	FCK.Focus() ;
}

FCKFitWindow.prototype.GetState = function()
{
	if ( FCKConfig.ToolbarLocation != 'In' )
		return FCK_TRISTATE_DISABLED ;
	else
		return ( this.originalCssText == null ? FCK_TRISTATE_OFF : FCK_TRISTATE_ON );
}

function FCKFitWindow_Resize()
{
	var oViewPaneSize = FCKTools.GetViewPaneSize( parent ) ;

	var eEditorFrameStyle = window.frameElement.style ;

	eEditorFrameStyle.width		= oViewPaneSize.Width + 'px' ;
	eEditorFrameStyle.height	= oViewPaneSize.Height + 'px' ;
}
