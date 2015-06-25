<p align="center">
    <a href="#markdownhtmlhelper">
        <img alt="logo" src="logo/150x150.png">
    </a>
</p>

# MarkdownHtmlHelper

[![][build-img]][build]
[![][nuget-img]][nuget]

ASP.NET MVC HTML Helper that renders Markdown content in Razor views.

**Note:** if you need something more straightforward consider using [MarkdownViewEngine][MarkdownViewEngine].

[build]:     https://ci.appveyor.com/project/TallesL/MarkdownHtmlHelper
[build-img]: https://ci.appveyor.com/api/projects/status/github/tallesl/MarkdownHtmlHelper

[nuget]:     http://badge.fury.io/nu/MarkdownHtmlHelper
[nuget-img]: https://badge.fury.io/nu/MarkdownHtmlHelper.png

[MarkdownViewEngine]: https://github.com/tallesl/MarkdownViewEngine

## Usage

```
@using MarkdownHtmlHelper

@{
    ViewBag.Title = "My Stupid Page";
    Layout = "~/Views/Shared/Layout.cshtml";
}

<h1>Here, have some Markdown:</h1>

@Html.Markdown("crazy-markdown-content.md")
```

