/// <reference path="app/logon.js" />
/// <reference path="/Scripts/jquery-1.7.2.js" />
/// <reference path="/Scripts/jquery-1.7.2-vsdoc.js" />
/// <reference path="/Scripts/jquery-ui-1.8.20.js" />
/// <reference path="/Scripts/backbone.js" />
/// <reference path="/Scripts/backbone.marionette.min.js" />
/// <reference path="/js/app/models/projects_model.js" />
/// <reference path="/js/app/views/projects_views.js" />
/// <reference path="/js/site.js" />


var AppRouter = Backbone.Router.extend({
    routes: {
        '': 'list',
        'projects/:id': 'projectDetails'
    },
    list: function () {
        this.projectList = new ProjectCollection();
        this.projectListView = new ProjectsListView({ model: this.projectList });
        this.projectHeaderView = new ProjectHeaderView();
        this.projectList.fetch();
        var header = this.projectHeaderView.render().el;
        var html = this.projectListView.render().el;
        $('#app').append(header);
        $('#app').append(html);
    },
    projectDetails: function (id) {
        this.project = this.projectList.get(id);
        this.projectView = new ProjectsListView({ model: this.project });
        var html = this.projectView.render().el;
        $('#app').html(html);
    }
});