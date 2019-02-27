var controlHtml = '<div class="hamburger-wrapper"><button class="hamburger">&#9776;</button><button class="cross">&#735;</button></div>';
$('.runtime-form.theme-entry').prepend(controlHtml);
$( '.hamburger').click(function() {
     $('.tab-box-tabs').slideToggle('slow', function() {
         $('.hamburger').hide();
         $('.cross').show();
     });
});

$('.cross').click(function() {
     $('.tab-box-tabs').slideToggle('slow', function() {
         $('.cross').hide();
         $('.hamburger').show();
     });
});