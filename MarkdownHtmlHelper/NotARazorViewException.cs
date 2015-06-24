namespace MarkdownHtmlHelper
{
    using System;

    /// <summary>
    /// Exception thrown when a view which isn't a Razor view is used with the helper.
    /// </summary>
    public class NotARazorViewException : Exception
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        internal NotARazorViewException() : base("MarkdownHtmlHelper helper only works with Razor views!") { }
    }
}
