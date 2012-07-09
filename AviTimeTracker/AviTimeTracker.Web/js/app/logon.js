/// <reference path="app/logon.js" />
/// <reference path="../Scripts/jquery-1.7.2.js" />
/// <reference path="../Scripts/jquery-1.7.2-vsdoc.js" />
/// <reference path="../Scripts/jquery-ui-1.8.20.js" />
/// <reference path="../Scripts/backbone.js" />
/// <reference path="../Scripts/backbone.marionette.min.js" />

var AviApp = AviApp || { };


AviApp.Login = (function($) {
    var post = function() {
        $('li.login-form ul.dropdown-menu li > img').on('click', null, function() {
            var id = $(this).attr('id');

            if (id == 'google-login-icon') {
                $('#loginIdentifier').val('https://www.google.com/accounts/o8/id');
            }
            $('#logon-form').submit();
        });
    };

    return { post: post };
})(jQuery);