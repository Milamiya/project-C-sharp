
var tooltipID='osdhtmltooltip';var imgtipID='osdhtmlpointer';document.write('<div id="'+tooltipID+'" style="VISIBILITY: hidden;"></div>');document.write('<img id="'+imgtipID+'" style="VISIBILITY: hidden;" src="oTooltiparrow.gif">');var offsetfromcursorX=12;var offsetfromcursorY=10;var offsetdivfrompointerX=10;var offsetdivfrompointerY=14;var ie=document.all;var ns6=document.getElementById&&!document.all;var enabletip=false;if(ie||ns6)
var tipobj=document.getElementById(tooltipID);var pointerobj=document.getElementById(imgtipID);function ietruebody(){return(document.compatMode&&document.compatMode!="BackCompat")?document.documentElement:document.body;}
function showtip(thetext,thewidth,thecolor){try{if(!tipobj.style)
return;if(ns6||ie){if(thewidth)
tipobj.style.width=thewidth+"px";if(thecolor&&thecolor!="")
tipobj.style.backgroundColor=thecolor;tipobj.innerHTML=thetext;enabletip=true;return false;}}
catch(e)
{}}
function positiontip(e){if(!tipobj.style)
return;if(enabletip&&pointerobj){var nondefaultpos=false;var curX=(ns6)?e.pageX:event.clientX+ietruebody().scrollLeft;var curY=(ns6)?e.pageY:event.clientY+ietruebody().scrollTop;var winwidth=ie&&!window.opera?ietruebody().clientWidth:window.innerWidth-20;var winheight=ie&&!window.opera?ietruebody().clientHeight:window.innerHeight-20;var rightedge=ie&&!window.opera?winwidth-event.clientX-offsetfromcursorX:winwidth-e.clientX-offsetfromcursorX;var bottomedge=ie&&!window.opera?winheight-event.clientY-offsetfromcursorY:winheight-e.clientY-offsetfromcursorY;var leftedge=(offsetfromcursorX<0)?offsetfromcursorX*(-1):-1000;if(rightedge<tipobj.offsetWidth){tipobj.style.left=curX-tipobj.offsetWidth+"px";nondefaultpos=true;}
else if(curX<leftedge)
tipobj.style.left="5px";else{tipobj.style.left=curX+offsetfromcursorX-offsetdivfrompointerX+"px";pointerobj.style.left=curX+offsetfromcursorX+"px";}
if(bottomedge<tipobj.offsetHeight){tipobj.style.top=curY-tipobj.offsetHeight-offsetfromcursorY+"px";nondefaultpos=true;}
else{tipobj.style.top=curY+offsetfromcursorY+offsetdivfrompointerY+"px";pointerobj.style.top=curY+offsetfromcursorY+"px";}
tipobj.style.visibility="visible";if(!nondefaultpos)
pointerobj.style.visibility="visible";else
pointerobj.style.visibility="hidden";}}
function hidetip(){if(!tipobj.style)
return;if(ns6||ie){enabletip=false;tipobj.style.visibility="hidden";pointerobj.style.visibility="hidden";tipobj.style.left="-1000px";tipobj.style.backgroundColor='';tipobj.style.width='';}}
document.onmousemove=positiontip;