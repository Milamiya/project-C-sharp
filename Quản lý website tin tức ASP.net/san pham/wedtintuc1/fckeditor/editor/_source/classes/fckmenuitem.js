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
 * File Name: fckmenuitem.js
 * 	FCKMenuItem Class: renders a menu items in a menu block.
 * 
 * File Authors:
 * 		Frederico Caldeira Knabben (fredck@fckeditor.net)
 */

var FCKMenuItem = function( name, label, iconPathOrStripInfoArray, isDisabled, direction )
{
	this.Name		= name ;
	this.Label		= label || name ;
	this.IsDisabled	= isDisabled ;
//	this.IsCheck	= isCheck ;
//	this.IsChecked	= isChecked ;
	this.Dir		= direction || 'ltr' ;
	
	this.Icon = new FCKIcon( iconPathOrStripInfoArray ) ;

	this.Items = new FCKMenuBlock( direction ) ;
	
	if ( FCK.IECleanup )
		FCK.IECleanup.AddItem( this, this._Cleanup ) ;
}


FCKMenuItem.prototype.AddItem = function( name, label, iconPathOrStripInfoArrayOrIndex, isDisabled )
{
	if ( this.Items )
	{
		if ( this.OnClick )
			this.Items.OnItemClick = this.OnClick ;
	}
	
	var oItem = this.Items.AddItem( name, label, iconPathOrStripInfoArrayOrIndex, isDisabled, this.Dir ) ;
	
	if ( this._FCKMenuBlock )
		oItem._FCKMenuBlock = this._FCKMenuBlock ;

	return oItem ;
}

FCKMenuItem.prototype.AddSeparator = function()
{
	this.Items.AddSeparator() ;
}

FCKMenuItem.prototype.Create = function( parentTable )
{
	var oDoc = parentTable.ownerDocument ;	// This is IE 6+

	var r = this.MainElement = parentTable.insertRow(-1) ;
	r.className = this.IsDisabled ? 'MN_Item_Disabled' : 'MN_Item' ;
	
	r._FCKMenuItem = this ;		// IE Memory Leak (Circular reference).
	
	if ( !this.IsDisabled )
	{
		r.onmouseover	= FCKMenuItem_OnMouseOver ;
		r.onmouseout	= FCKMenuItem_OnMouseOut ;
		r.onclick		= FCKMenuItem_OnClick ;
	}
	
	var eCell = r.insertCell(-1) ;
	eCell.className = 'MN_Icon' ;
	
	/*
	// Support for Check style element.
	if ( this.IsCheck )
	{
		var eDiv = eCell.appendChild( oDoc.createElement( 'DIV' ) ) ;
		eDiv.className = 'TB_Button_Image' ;
		eDiv.style.height = 6 ;
		
		this.CheckImg = eDiv.appendChild( oDoc.createElement( 'IMG' ) ) ;
		this.CheckImg.src = FCK_IMAGES_PATH + 'check.gif' ;
		this.CheckImg.width	 = 7 ;
		this.CheckImg.height = 6 ;

		if ( !this.IsChecked )
			this.CheckImg.style.display = 'none' ;
	}
	else
	*/
		eCell.appendChild( this.Icon.CreateIconElement( oDoc ) ) ;

	eCell = r.insertCell(-1) ;
	eCell.className = 'MN_Label' ;
	eCell.noWrap = true ;
	eCell.appendChild( oDoc.createTextNode( this.Label ) ) ;
	
	eCell = r.insertCell(-1) ;
	if ( this.Items.Items.length > 0 )
	{
		eCell.className = 'MN_Arrow' ;

		var eArrowImg = eCell.appendChild( oDoc.createElement( 'IMG' ) ) ;
		eArrowImg.src = FCK_IMAGES_PATH + 'arrow_' + this.Dir + '.gif' ;
		eArrowImg.width	 = 4 ;
		eArrowImg.height = 7 ;
		
		var oItemsPanelWin ;
		
		if ( !FCKBrowserInfo.IsIE && this.Panel )
			oItemsPanelWin = this.Panel._Window ;
		else
			oItemsPanelWin = FCKTools.GetParentWindow( oDoc ) ;

		var oItemsPanel = this.ItemsPanel = new FCKPanel( oItemsPanelWin, true ) ;
		oItemsPanel.EnableContextMenu( false ) ;
		oItemsPanel.SetDirection( this.Dir ) ;
		oItemsPanel.AppendStyleSheet( FCKConfig.SkinPath + 'fck_editor.css' ) ;
		
		if ( !FCKBrowserInfo.IsIE )
		{
			oItemsPanel._FCKMenuItem = this ;
			oItemsPanel.OnHide = FCKMenuItem_ItemsPanel_OnHide ;
		}
		
		this.Items.Panel = oItemsPanel ;
		this.Items.Create( oItemsPanel.MainNode ) ;		
	}
}

FCKMenuItem.prototype._Cleanup = function()
{
	if ( this.MainElement )
	{
		this.MainElement._FCKMenuItem = null ;
	}
}

/*
	Events
*/

function FCKMenuItem_ItemsPanel_OnHide()
{
	var oPanel = this._FCKMenuItem.Panel ;
	
	if ( oPanel )
	{
		oPanel.CanHide = true ;
		oPanel.Hide( true ) ;
	}
}

function FCKMenuItem_OnMouseOver()
{
	this.className = 'MN_Item_Over' ;
}

function FCKMenuItem_OnMouseOut()
{
	this.className = 'MN_Item' ;
}

function FCKMenuItem_OnClick()
{
	var oMenuItem = this._FCKMenuItem ;

	if ( oMenuItem.ItemsPanel )
	{
		if ( oMenuItem.Panel )
			oMenuItem.Panel.CanHide = false ;

		// Show the child menu block. The ( +2, -2 ) correction is done because
		// of the padding in the skin. It is not a good solution because one
		// could change the skin and so the final result would not be accurate.
		// For now it is ok because we are controlling the skin.
		oMenuItem.ItemsPanel.Show( oMenuItem.MainElement.offsetWidth + 2, -2, oMenuItem.MainElement ) ;
	}
	else
	{
		this.className = 'MN_Item' ;

		/*
		if ( oMenuItem.IsCheck )
		{
			oMenuItem.IsChecked = !oMenuItem.IsChecked ;
			oMenuItem.CheckImg.style.display = oMenuItem.IsChecked ? '' : 'none' ;
		}
		*/
		
		if ( oMenuItem.OnClick )
			oMenuItem.OnClick( oMenuItem ) ;
	}
}