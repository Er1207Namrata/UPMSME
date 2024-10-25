
jQuery(document).ready(function($) {
    // owl js start here

      var owl = $('#banner-slider');
        owl.owlCarousel({
            autoplay:true,
            autoplayTimeout:2000,
            autoplayHoverPause:true,        
            loop:true,
            margin:0,
            items:1,
            nav: false,
            dots: true,       
        }) 
      // owl js end here


      // accordion js start here
      $(".accordion .accordion-header").click(function(){
        $(this).parent(".accordion-item").siblings().removeClass("show");
        $(this).parent(".accordion-item").toggleClass("show");
        $(this).parent().siblings(".accordion-item").children(".accordion-body").slideUp();
        $(this).next(".accordion-body").slideToggle();
      });

      // accordion js end here

      // tab js start here
      $('.tabs ul li a:not(:first)').addClass('selected');
        $('.tab-content .tab-inner').hide();
        $('.tab-content .tab-inner:first').show();        
        $('.tabs ul li a').click(function(){
            var t = $(this).attr('id');
          if($(this).hasClass('selected')){ //this is the start of our condition 
            $('.tabs ul li a').addClass('selected');           
            $(this).removeClass('selected');
            
            $('.tab-content .tab-inner').hide();
            $('#'+ t + 'C').fadeIn('slow');
         }
        });
        // tab js end here

        $(".apply-now-btn").click(function() {
            $('html, body').animate({
                scrollTop: $("#apply-form").offset().top
            }, 100);
        });
      
      
});