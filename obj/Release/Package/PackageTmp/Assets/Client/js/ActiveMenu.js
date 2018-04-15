$(document).ready(function ($) {
    //Get current part and find target link
    var path = window.location.pathname.split('/').pop();

    //Account for home page with empty path
    if (path == '') {
        path = 'Index';
    }

    var target = $('nav a[href="' + path + '"]');
    //add activeclass to target link
    target.addClass('active');
});