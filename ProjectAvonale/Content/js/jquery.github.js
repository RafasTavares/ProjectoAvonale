﻿
//"<a  href='  @Url.Action('DetalharRepositorio', 'RepositoriosController', " + this.name + ") '>" + this.name + "</a>" +


/*
*  jQuery Github Repos v0.2.2
*  A jQuery plugin to display your Github Repositories.
*  http://git.io/3A1RMg
*
*  Zeno Rocha
*  MIT License
*/

(function (a, b) { function g(b, c) { this.element = b, this.$container = a(b), this.repo = this.$container.attr("data-repo"), this.cached, this.options = a.extend({}, f, c), this._defaults = f, this._name = d, this.init() } var d = "githubRepos", f = (b.document, { propertyName: "value" }); g.prototype.init = function () { var e, d = this; b.sessionStorage && (e = sessionStorage.getItem("gh-repos:" + this.repo)), null != e ? d.applyTemplate(JSON.parse(e)) : a.ajax({ url: "https://api.github.com/repos/" + this.repo, dataType: "jsonp", success: function (a) { return a.meta.status >= 400 && a.data.message ? (console.warn(a.data.message), c) : (d.applyTemplate(a.data), b.sessionStorage && sessionStorage.setItem("gh-repos:" + d.repo, JSON.stringify(a.data)), c) } }) }, g.prototype.applyTemplate = function (b) { var c = this, d = new Date(b.pushed_at), e = d.getDate() + "/" + (d.getMonth() + 1) + "/" + d.getFullYear(), f = a('         <div class="github-box">              <div class="github-box-header">                 <h3>                    <a href="DetalharRepositorio">' + b.name + '</a>                </h3>                 <div class="github-stats">                     <a class="repo-watchers" href="' + b.url.replace("api.", "").replace("repos/", "") + '/watchers">' + b.watchers + '</a>                     <a class="repo-forks" href="' + b.url.replace("api.", "").replace("repos/", "") + '/forks">' + b.forks + '</a>                 </div>             </div>             <div class="github-box-content">                 <p>' + b.description + ' &mdash; <a href="' + b.url.replace("api.", "").replace("repos/", "") + '#readme">Read More</a></p>             </div>             <div class="github-box-download">                 <p class="repo-update">Latest commit to <strong>master</strong> on ' + e + '</p>                 <a class="repo-download" href="' + b.url.replace("api.", "").replace("repos/", "") + '/zipball/master">Download as zip</a>             </div>         </div>       '); c.appendTemplate(f) }, g.prototype.appendTemplate = function (a) { var b = this; a.appendTo(b.$container) }, a.fn[d] = function (b) { return this.each(function () { a.data(this, "plugin_" + d) || a.data(this, "plugin_" + d, new g(this, b)) }) } })(jQuery, window);