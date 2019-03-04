(function(){
    var btn = $('<a id="scrollUpBtn" name="scrollUpBtn" href="#" onclick="topFunction()" class="SFC SourceCode-Forms-Controls-Web-Button" >Go to top</a>');
    $('body').append(btn);

    window.onscroll = scrollFunction;

    function scrollFunction() {
        if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
            document.getElementById("scrollUpBtn").style.display = "block";
        } else {
            document.getElementById("scrollUpBtn").style.display = "none";
        }
    }
    // function topFunction() {
    //     document.body.scrollTop = 0;
    //     document.documentElement.scrollTop = 0;
    // }
})();