$(document).ready(function(){
   $ ('.slideshow img:gt(0)').hide();
        setInterval(function(){
     $ ('.slideshow :first-child').fadeOut()
             .next('img').fadeIn()
         .end().appendTo('.slideshow');}, 
          1000);
          })
          
     
   function edit_confirm()
     { 
    var result = confirm("Bạn có thực sự muốn thanh toán không?");    
    if(result)
    {
        return true;
    }    
    return false;
    }       