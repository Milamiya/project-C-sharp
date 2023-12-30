/*** Freeware Open Source writen by ngoCanh 2002-05                  */
/*** Original by Vietdev  http://vietdev.sourceforge.net             */
/*** Release 2004-03-14  R9.0                                        */
/*** GPL - Copyright protected                                       */
/*** Bo^. go~ tie^'ng Vie^.t cho input-text, textarea va` iframe     */
/*********************************************************************/

if(typeof(ALLFRAME)=="undefined")ALLFRAME=1//Frame
if(typeof(ON_OFF)=="undefined")ON_OFF=1//VietTyping 1:ON, 0:OFF
if(typeof(MOD)=="undefined")MOD=2//VietTyping-mode 0:Auto, 1:Vni, 2:Telex, 3:VIQR
if(typeof(SPELL)=="undefined")SPELL=0//Check vietnamese word  0:No-check, 1:Yes
if(typeof(NEWV)=='undefined')NEWV=1//0,1  1=hoa`; 0=ho`a
if(typeof(STATUS)=='undefined')STATUS=0//statusmessage
ESC=0,FRA=null,TXT=null

if(typeof(getScriptPath)=='undefined')
{
function getScriptPath(script)
{
  var i=0,p='';
  var scrA=document.getElementsByTagName('script')
  while(scrA[i])
  {
   var src=scrA[i].src
   if(src&&src.lastIndexOf(script)>=0){p=src.substring(0,src.lastIndexOf(script));break;}
   i++
  }

  if(p.indexOf("://")>=0||p.indexOf("/")==0)return p
  p=p.replace(/^\.\//,"/")

  var href=document.location.href
  if(href.indexOf('?')>=0) href= href.substring(0,href.indexOf('?'));
  href=href.substring(0,href.lastIndexOf('/'))
  
  if(p=='.'||p=='')return href
  else if(p.indexOf('..')>=0)
   {
    var sub=''
    if(p.length>2)sub=p.substr(p.lastIndexOf('../')+2)
    var temp=p.split('..')
    for(var i=1;i<temp.length;i++)
     {href=href.substring(0,href.lastIndexOf('/'))}
    if(sub!='/..')href +=sub
   }
  else if(p!='') href +=p;
  return href
}
}

if(document.all)document.writeln('<script src="lib/viettyping_IE.js"></script>');
else document.writeln('<script src="lib/viettyping_Moz.js"></script>');
