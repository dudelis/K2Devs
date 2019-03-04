$(document).ready(function(){
    $('textarea').each(function(index, obj){
        $wrapper = $(obj).closest('.input-control.text-input');
        var width = $wrapper.width();
        $wrapper.css('width', '');
        $(obj).css('width', width + 'px');
        $(obj).resizable();
    });
});