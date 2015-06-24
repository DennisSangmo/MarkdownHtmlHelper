<p align="center">
    <a href="#markdownhtmlhelper">
        <img alt="logo" src="logo/150x150.png">
    </a>
</p>

# MarkdownHtmlHelper

[![nuget package](https://badge.fury.io/nu/MarkdownHtmlHelper.png)](http://badge.fury.io/nu/MarkdownHtmlHelper)

ASP.NET MVC HTML Helper that renders Markdown content in Razor views.

**Note:** if you need something more straightforward consider using [MarkdownViewEngine](https://github.com/tallesl/MarkdownViewEngine).

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

