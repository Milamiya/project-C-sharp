var urlLogin = "";
function confirmimages(url){
$('select').hide();
$('.popups').show();
$('.overlay').show();
//window.location = url;
urlLogin = url;
}

function confirmimage(url){
$('select').hide();
$('.popup').show();
$('.overlay').show();
//window.location = url;
urlLogin = url;
}
function forwardLogin(){
window.location = 'http://aha.vn';
}