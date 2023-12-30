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
 * File Name: fckmenublock.js
 * 	FCKMenuBlock Class: renders a list of menu items.
 * 
 * File Authors:
 * 		Frederico Caldeira Knabben (fredck@fckeditor.net)
 */

var FCKMenuBlock = function( direction )
{
	this.Dir	= direction || 'ltr' ;
	this.Items	= new Array() ;
	
	if ( FCK.IECleanup )
		FCK.IECleanup.AddItem( this, this._Cleanup ) ;
}

FCKMenuBlock.prototype.AddItem = function( name, label, iconPathOrStripInfoArrayOrIndex, isDisabled )
{
	if ( typeof( iconPathOrStripInfoArrayOrIndex ) == 'number' )
		 iconPathOrStripInfoArrayOrIndex = [ FCKConfig.SkinPath + 'fck_strip.gif', 16, iconPathOrStripInfoArrayOrIndex ] ;

	var oItem = new FCKMenuItem( name, label, iconPathOrStripInfoArrayOrIndex, isDisabled, this.Dir ) ;
	oItem.Dir = this.Dir ;
	
	oItem._FCKMenuBlock = this ;
	oItem.OnClick = FCKMenuBlock_OnItemClick ;
	
	this.Items[ this.Items.length ] = oItem ;
	
	return oItem ;
}

FCKMenuBlock.prototype.AddSeparator = function()
{
	this.Items[ this.Items.length ] = new FCKMenuSeparator() ;
}

FCKMenuBlock.prototype.RemoveAllItems = function()
{
	this.Items = new Array() ;
}

FCKMenuBlock.prototype.Create = function( parentElement )
{
	if ( this.MainElement )
	{
		this.MainElement.parentNode.removeChild( this.MainElement ) ;
		this._Cleanup() ;
	}

	var oDoc = parentElement.ownerDocument ;

	var eTable = oDoc.createElement( 'table' ) ;
	eTable.dir = this.Dir ;
	eTable.cellPadding = 0 ;
	eTable.cellSpacing = 0 ;
	
	var oMainElement = this.MainElement = eTable.insertRow(-1).insertCell(-1) ;
	oMainElement.className = 'MN_Menu' ;
	
	var eItemsTable = oMainElement.appendChild( oDoc.createElement( 'table' ) ) ;
	eItemsTable.cellPadding = 0 ;
	eItemsTable.cellSpacing = 0 ;
	
	for ( var i = 0 ; i < this.Items.length ; i++ )
	{
		var oItem = this.Items[i] ;
		
		if ( this.Panel )
			oItem.Panel = this.Panel ;

		oItem.Create( eItemsTable ) ;
	}
	
	parentElement.appendChild( eTable ) ;
	
	// Disable mouse selection on the block.
	FCKTools.DisableSelection( eTable ) ;
}

FCKMenuBlock.prototype._Cleanup = function()
{
	this.MainElement = null ;
}

function FCKMenuBlock_OnItemClick( menuItem )
{
	var oMenuBlock = menuItem._FCKMenuBlock ;
	
	if ( oMenuBlock.OnItemClick )
		oMenuBlock.OnItemClick( oMenuBlock, menuItem ) ;
}

var FCKMenuSeparator = function()
{}

FCKMenuSeparator.prototype.Create = function( parentTable )
{
	var oDoc = parentTable.ownerDocument ;	// This is IE 6+

	var r = parentTable.insertRow(-1) ;
	
	var eCell = r.insertCell(-1) ;
	eCell.className = 'MN_Separator MN_Icon' ;

	eCell = r.insertCell(-1) ;
	eCell.className = 'MN_Separator' ;
	eCell.appendChild( oDoc.createElement( 'DIV' ) ).className = 'MN_Separator_Line' ;

	eCell = r.insertCell(-1) ;
	eCell.className = 'MN_Separator' ;
	eCell.appendChild( oDoc.createElement( 'DIV' ) ).className = 'MN_Separator_Line' ;
}