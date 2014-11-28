namespace TelerikAcademyForumRSS
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class HtmlCreator
    {
        private string htmlLiTemplate = "<li><a href=\"{0}\"><b>[{1}]</b> {2} <i>({3})</i></li>";

        public string GenerateHtmlFile(IEnumerable<Item> collection)
        {
            StringBuilder html = new StringBuilder();

            html.AppendLine("<ul>");

            foreach (var entity in collection)
            {
                html.AppendFormat(htmlLiTemplate,
                                entity.Link,
                                entity.Category,
                                entity.Title,
                                entity.PubDate.ToShortDateString());
            }

            html.AppendLine("</ul>");

            return html.ToString();
        }
    }
}
