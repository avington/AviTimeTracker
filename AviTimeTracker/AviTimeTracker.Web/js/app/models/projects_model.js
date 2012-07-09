/// <reference path="app/logon.js" />
/// <reference path="/Scripts/jquery-1.7.2.js" />
/// <reference path="/Scripts/jquery-1.7.2-vsdoc.js" />
/// <reference path="/Scripts/jquery-ui-1.8.20.js" />
/// <reference path="/Scripts/backbone.js" />
/// <reference path="/Scripts/backbone.marionette.min.js" />
/// <reference path="/js/app/routes/projects_routes.js" />
/// <reference path="/js/app/views/projects_views.js" />
/// <reference path="/js/site.js" />


window.Project = Backbone.Model.extend({
    idAttribute: 'Id',
    urlRoot: '/AviTimeTracker/api/projects',
    defaults: {
        id: null,
        Name: "",
        Description: "",
        CompanyName: "",
        CompanyCode: ""
    }
});

window.ProjectCollection = Backbone.Collection.extend({
    model: Project,
    url: '/AviTimeTracker/api/projects'
});

