var current_slide = 1;
 var total_slide = 0; 
var current_y = 0; 
function change_slide_int(order){
	 
	for(i =1; i <= total_slide; i++){
		if(order != i){
			$('#slide-div-' + i).css('display','none');	 
			$('#dot-slide-' + i).removeClass('slidebar');
			 
		}
	}
 	$('#slide-div-' + order).css('display','block');
	$('#slide-div-' + order).animate({opacity: 1.0}, 500 ) ; 
	 
 	$('#dot-slide-' + order).addClass('slidebar-active');
	
	
	
	current_slide = order;

}
 
function doSwitch(order) {
	current_slide = order -1;
	current_y = - (current_slide -1) * 213;
	slideSwitch1();
	
}

function slideSwitch() {
	    
		 
			$('#slide-div-' + current_slide).animate({opacity:  0}, 800 );
			$('#slide-div-' + current_slide).css('display','none');	 
			$('#dot-slide-' + current_slide).removeClass('slidebar-active');
			$('#dot-slide-' + current_slide).addClass('slidebar');
			
			current_slide = current_slide + 1;
			if(current_slide > total_slide){
				current_slide = 1;
			}
			 
			$('#slide-div-' + current_slide).css('display','block');
			$('#slide-div-' + current_slide).animate({opacity: 1.0}, 1100 ) ; 
			$('#dot-slide-' + current_slide).removeClass('slidebar');
			$('#dot-slide-' + current_slide).addClass('slidebar-active');
	 
}
function slideSwitch1() {
	
	for(i = 1; i <= total_slide; i++){
		$('#dot-slide-' + i).removeClass('slidebar-active');
		$('#dot-slide-' + i).addClass('slidebar');
	}
	
	
	current_slide = current_slide + 1;
	
	
	current_y = current_y - 213; 
	if(current_slide >  total_slide){
		 
		current_y = 0;
		current_slide = 1
		//$('#bar-content').animate({ top:  current_y },510);
	}else{
		
	}
	
	$('#bar-content').animate({ top:  current_y },510);
	
		 
	$('#dot-slide-' + current_slide).removeClass('slidebar');
	$('#dot-slide-' + current_slide).addClass('slidebar-active');
	

}

$(function() {
	    total = $('#count-total-slide').html();
	    total_slide =   total;
        setInterval( "slideSwitch1()", 8000 );
		 
});

 