/// <reference path="app/logon.js" />
/// <reference path="../Scripts/jquery-1.7.2.js" />
/// <reference path="../Scripts/jquery-1.7.2-vsdoc.js" />
/// <reference path="../Scripts/jquery-ui-1.8.20.js" />
/// <reference path="../Scripts/backbone.js" />
/// <reference path="../Scripts/backbone.marionette.min.js" />
/// <reference path="app/models/projects_model.js" />
/// <reference path="app/routes/projects_routes.js" />
/// <reference path="app/views/projects_views.js" />
/// <reference path="site.js" />

AviApp.Login = AviApp.Login || {};
var app = new AppRouter();
Backbone.history.start();

(function($) {
    $(document).ready(function() {
        AviApp.Login.post();
    });
})(jQuery);

