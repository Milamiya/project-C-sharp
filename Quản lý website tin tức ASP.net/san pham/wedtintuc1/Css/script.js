var corner_image = '/themes/apolloedu/images/frame.png'
var site_domain = 'http://apollo.edu.vn';
$(function() {
	  
       
      
       if ( (/MSIE 6\.0/).test(navigator.userAgent) && !(/MSIE 7\.0/).test(navigator.userAgent) ) {
		DD_belatedPNG.fix(".FixPng");
		 
	   }else{
	   
			$('.image-corner').each(function(){
				var image = $(this).attr('src');
			   
				image = image.replace(site_domain,'');
				 
				 $(this).attr('style', 'background:transparent  url(' + escape(image) + ') no-repeat left top;');
				 $(this).attr('src', corner_image);
		   
		   } );
	   
	   }
        
		 
});

function submit_search(){
    $('#search-submit').click();

}

 var timeout         = 500;
var closetimer		= 0;
var ddmenuitem      = 0;
var current_parrent = 0;
function jsddm_open()
{	jsddm_canceltimer();
    jsddm_close();
    ddmenuitem = $(this).find('ul').eq(0).css('visibility', 'visible'); 
    current_parrent =  $(this).find('a').eq(0).addClass('li-active'); 
    // parrent = $(this).attr('ref');
    // alert(this.className );
    //$('.' + parrent).css('background-color', '#FF0000');
    //current_parrent = $(this).parent('ul').parent('.js-parent').find.addClass('li-active');
     
    
}
     

function jsddm_close()
{	if(ddmenuitem) ddmenuitem.css('visibility', 'hidden');

    if(current_parrent) current_parrent.removeClass('li-active');
     
}


function jsddm_timer()
{	closetimer = window.setTimeout(jsddm_close, timeout);}

function jsddm_canceltimer()
{	if(closetimer)
    {	window.clearTimeout(closetimer);
        closetimer = null;
    }
        
}
function set_cureent(){
    current_parrent = this;

}
$(document).ready(function()
{	
//$('#jsddm > li').bind('mouseover', jsddm_open);
//$('#jsddm > li').bind('mouseout',  jsddm_timer);
    
    
   // jQuery("#jsddm").Smartmenu({animationDuration: 350});
   
}
);
//SyntaxHighlighter.all();
document.onclick = jsddm_close;