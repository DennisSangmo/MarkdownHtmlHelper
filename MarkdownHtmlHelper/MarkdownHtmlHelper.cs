namespace MarkdownHtmlHelper
{
    using CommonMark;
    using System.IO;
    using System.Web;
    using System.Web.Mvc;

    /// <summary>
    /// An HTML Helper that renders markdown.
    /// </summary>
    public static class MarkdownHelper
    {
        /// <summary>
        /// Reads the content of the given file path, interprets as markdown and renders the equivalent HTML.
        /// </summary>
        /// <param name="helper">Html helper</param>
        /// <param name="path">The file with the markdown content to be rendered</param>
        /// <returns>The rendered HTML</returns>
        public static IHtmlString Markdown(this HtmlHelper helper, string path)
        {
            var view = helper.ViewContext.View as RazorView;
            if (view == null)
            {
                throw new NotARazorViewException();
            }
            else
            {
                var viewPath = helper.ViewContext.HttpContext.Server.MapPath(view.ViewPath);
                var dir = Path.GetDirectoryName(viewPath);
                var fullpath = Path.Combine(dir, path);
                var unparsed = File.ReadAllText(fullpath);
                var parsed = CommonMarkConverter.Convert(unparsed);
                return new MvcHtmlString(parsed);
            }
        }
    }
}
