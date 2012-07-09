/// <reference path="app/logon.js" />
/// <reference path="/Scripts/jquery-1.7.2.js" />
/// <reference path="/Scripts/jquery-1.7.2-vsdoc.js" />
/// <reference path="/Scripts/jquery-ui-1.8.20.js" />
/// <reference path="/Scripts/backbone.js" />
/// <reference path="/Scripts/backbone.marionette.min.js" />
/// <reference path="/js/app/routes/projects_routes.js" />
/// <reference path="/js/app/models/projects_model.js" />
/// <reference path="/js/site.js" />

window.ProjectsListView = Backbone.View.extend({
    tagName: 'section',
    className: 'gridSystem',
    initialize: function () {
        this.model.on('reset', this.render, this);
        var self = this;
        this.model.on('add', function(project) {
            $(self.el).append(new ProjectListItemView({ model: project }));
        });
    },
    render: function (eventName) {
        _.each(this.model.models, function (project) {
            $(this.el).append(new ProjectListItemView({ model: project }).render().el);
        }, this);
        return this;
    }
});

window.ProjectListItemView = Backbone.View.extend({
    tagName: "div",
    className: 'row show-grid',
    initialize: function () {
        this.model.on('change', this.render, this);
        this.model.on('destroy', this.close, this);
    },
    render: function (eventName) {
        var $template = $('#project-index-item-template');
        var model = this.model.toJSON();
        console.log('model: ', this);
        var html = $template.render(model);
        $(this.el).html(html);
        return this;
    },
    close: function () {
        $(this.el).off();
        $(this.el).remove();
    }
});

window.projectView = Backbone.View.extend({
    initialize: function() {
        this.model.on('change', this.render, this);
    },
    render: function(eventName) {
        var template = $('#project-edit-template');
        var model = this.model.toJSON();
        $(this.el).html(template.render(model));
        return this;
    },
    events: {
        'change input': 'change',
        'click .save': 'saveProject'
    },
    change: function(event) {
        var target = event.target;
        console.log('changing: ' + target.id + ' from: ' + target.defaultValue + ' to: ' + target.value);
        // You could change your model on the spot, like this:
        // var change = {};
        // change[target.name] = target.value;
        // this.model.set(change);
    },
    saveProject: function() {
        this.model.set({
            Name: $('#project-name'),
            Description: $('#project-description'),
            CompanyName: $('#project-company-name'),
            CompanyCode: $('#project-company-code')
        });
        if (this.model.isNew()) {
            app.projectList.create(this.model);
        } else {
            this.model.save();
        }
        return false;
    },
    close: function() {
        $(this.el).off();
        $(this.el).empty();
    }
});

window.ProjectHeaderView = Backbone.View.extend({
    tagName: 'div',
    className: 'page-header',
    initialize: function () {
        this.render();
    },
    render: function () {
        var template = $('#project-header-template');
        $(this.el).html(template.render(null));
        return this;
    }
})