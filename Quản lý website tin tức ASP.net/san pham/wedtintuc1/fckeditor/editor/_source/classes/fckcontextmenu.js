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
 * File Name: fckcontextmenu.js
 * 	FCKContextMenu Class: renders an control a context menu.
 * 
 * File Authors:
 * 		Frederico Caldeira Knabben (fredck@fckeditor.net)
 */

var FCKContextMenu = function( parentWindow, mouseClickWindow, langDir )
{
	var oPanel = this._Panel = new FCKPanel( parentWindow, true ) ;
	oPanel.AppendStyleSheet( FCKConfig.SkinPath + 'fck_editor.css' ) ;
	oPanel.IsContextMenu = true ;
	oPanel.EnableContextMenu( false ) ;
	
	var oMenuBlock = this._MenuBlock = new FCKMenuBlock() ;
	oMenuBlock.Dir = langDir ;
	oMenuBlock._FCKContextMenu = this ;
	oMenuBlock.Panel = oPanel ;
	oMenuBlock.OnItemClick = FCKContextMenu_MenuBlock_OnItemClick ;
	
	this._Redraw = true ;
	
	this.SetMouseClickWindow( mouseClickWindow || parentWindow ) ;
}

FCKContextMenu.prototype.SetMouseClickWindow = function( mouseClickWindow )
{
	if ( !FCKBrowserInfo.IsIE )
	{
		this._Document = mouseClickWindow.document ;
		this._Document.addEventListener( 'contextmenu', FCKContextMenu_Document_OnContextMenu, false ) ;
	}
}

FCKContextMenu.prototype.AddItem = function( name, label, iconPathOrStripInfoArrayOrIndex, isDisabled )
{
	var oItem = this._MenuBlock.AddItem( name, label, iconPathOrStripInfoArrayOrIndex, isDisabled) ;
	this._Redraw = true ;
	return oItem ;
}

FCKContextMenu.prototype.AddSeparator = function()
{
	this._MenuBlock.AddSeparator() ;
	this._Redraw = true ;
}

FCKContextMenu.prototype.RemoveAllItems = function()
{
	this._MenuBlock.RemoveAllItems() ;
	this._Redraw = true ;
}

FCKContextMenu.prototype.AttachToElement = function( element )
{
	element._FCKContextMenu = this ;
	if ( FCKBrowserInfo.IsIE )
		element.oncontextmenu = FCKContextMenu_AttachedElement_OnContextMenu ;
//	element.onmouseup		= FCKContextMenu_AttachedElement_OnMouseUp ;
}

function FCKContextMenu_Document_OnContextMenu( e )
{
	var el = e.target ;
	
	while ( el )
	{
		if ( el._FCKContextMenu )
		{
			FCKTools.CancelEvent( e ) ;
			FCKContextMenu_AttachedElement_OnContextMenu( e, el ) ;
		}
		el = el.parentNode ;
	}
}

function FCKContextMenu_AttachedElement_OnContextMenu( e, el )
{
//	var iButton = e ? e.which - 1 : event.button ;

//	if ( iButton != 2 )
//		return ;

	var oIEEvent ;
	if ( !e )
		oIEEvent = FCKTools.GetElementWindow( this ).event ;

	var eTarget = el || ( e ? e.target : this ) ;

	var oContextMenu = eTarget._FCKContextMenu ;
	
	if ( oContextMenu.OnBeforeOpen )
		oContextMenu.OnBeforeOpen.call( oContextMenu, eTarget ) ;
	
	if ( oContextMenu._Redraw )
	{
		oContextMenu._MenuBlock.Create( oContextMenu._Panel.MainNode ) ;
		oContextMenu._Redraw = false ;
	}

	oContextMenu._Panel.Show( 
		e ? e.pageX : oIEEvent.screenX, 
		e ? e.pageY : oIEEvent.screenY, 
		e ? e.currentTarget : null
	) ;
	
	return false ;
}

function FCKContextMenu_MenuBlock_OnItemClick( menuBlock, menuItem )
{
	var oContextMenu = menuBlock._FCKContextMenu ;
	
	oContextMenu._Panel.Hide() ;
	
	if ( oContextMenu.OnItemClick )
		oContextMenu.OnItemClick.call( oContextMenu, menuItem ) ;
}