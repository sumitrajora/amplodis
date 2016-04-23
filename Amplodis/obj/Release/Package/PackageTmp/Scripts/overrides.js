    $(document).ready(function(){
        
        // Navigation for Mobile
        var touch = $('#touch-menu');
        var menu = $('.menu');
         
            $(touch).on('click', function(e) {
                e.preventDefault();
                menu.slideToggle();
            });

            $(window).resize(function(){
                var w = $(window).width();
                if(w > 767 && menu.is(':hidden')) {
                menu.removeAttr('style');
                }
            });

        //Header Scroll fix
        //var wrap = $(".navbar");


       /* wrap.on("scroll", function(e) {
            alert("hi");
            
          if (this.scrollTop > 147) {
            wrap.addClass("fix-search");
          } else {
            wrap.removeClass("fix-search");
          }
          
        }); */


    });

    $(function(){
        // Check the initial Poistion of the Sticky Header
        var wrap = $("#navbar");
        var fixnavbarTop = $('#navbar').offset().top;
        $(window).scroll(function(){
        if( $(window).scrollTop() > fixnavbarTop ) {
            //alert("kapil");
            //wrap.addClass("fix-navbar");
        
        } else {
        
            //alert("elsekapil");
           // wrap.removeClass("fix-navbar");
        }
        });

        function setHeight() {
            headerHeight = $('#page1').height();            
            windowHeight = $(window).height();
            
            vHeight = 'min-height';
            $('#page2').css(vHeight, windowHeight-headerHeight);
            $('#page3').css(vHeight, windowHeight-headerHeight);
            $('#page4').css(vHeight, windowHeight-headerHeight);
            $('#page5').css(vHeight, windowHeight-headerHeight);
        }

        $(window).on('resize',function(){ setHeight();})
        $(window).on('scroll',function(){ setHeight();})
        setHeight();

    }); 