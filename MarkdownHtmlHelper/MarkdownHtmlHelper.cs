namespace MarkdownHtmlHelper
{
    using System.IO;
    using System.Web;
    using System.Web.Mvc;
    using MarkdownSharp;

    /// <summary>
    /// An HTML Helper that renders markdown.
    /// </summary>
    public static class MarkdownHelper
    {
        /// <summary>
        /// SO's markdown parser.
        /// </summary>
        private static readonly Markdown _parser = new Markdown();

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
                var parsed = _parser.Transform(unparsed);
                return new MvcHtmlString(parsed);
            }
        }
    }
}
