/*
 * Copyright (c) 2013 MyPassion
 * Author: MyPassion 
 * This file is made for CURRENT TEMPLATES
*/

	








jQuery(document).ready(function($){
		
	"use strict";	
	
	

// -----------------------------------------------------  CBPQTROTATOR		
	jQuery( '#cbp-qtrotator' ).cbpQTRotator({
		/*
		- how to call the plugin:
		$( selector ).cbpQTRotator( [options] );
		- options:
		{
			// default transition speed (ms)
			speed : 700,
			// default transition easing
			easing : 'ease',
			// rotator interval (ms)
			interval : 8000
		}
		- destroy:
		$( selector ).cbpQTRotator( 'destroy' );
		*/

	});



// -----------------------------------------------------  MENU
	if(jQuery().superfish){
		jQuery('ul.sf-menu').superfish({
			delay:       100,                            // one second delay on mouseout
			speed:       'fast',                          // faster animation speed
			autoArrows:  true                            // disable generation of arrow mark-up	
		});	
	}
	
	jQuery('#nav ul li li a').mouseenter(function() {
			jQuery(this).animate({ paddingLeft:'+=10'}, 200, 'swing');
		}).mouseleave(function() {
			jQuery(this).animate({ paddingLeft:'-=10'}, 200, 'swing');
		});
	
	
	var winWidth = jQuery(window).width();
	
	if( winWidth > 979 ){
		jQuery("nav").sticky({ topSpacing: 0});	
	}
		
	function header() {
		var windowHeight = jQuery(window).height();
		var windowHeight2 = jQuery(window).height();
		var header = jQuery("#header");
		var slider = jQuery(".ri-grid");
		header.css("height",windowHeight+"px");
		slider.css("height",windowHeight+"px");

	}
	
	
	
	
	
	function navi(){
		var topSpace = jQuery(window).scrollTop();
		var winHeight = jQuery(window).height();
		
		if(topSpace >= winHeight){
			
			if(!jQuery('#nav').is(':animated')) {
			
				jQuery('#nav').stop(true,true).slideDown(500);
			
			}
			
		}else{
			if(!jQuery('#nav').is(':animated')) {

				jQuery('#nav').stop(true,true).slideUp(500);	
			
			}
		}
	}
	
	jQuery(window).bind('scroll', function(){
		if(jQuery(window).width()>979){navi();}
	})
	
	








	
	
	
	

	
	
	
	
	
});
