using Sitecore.Shell.Controls.RichTextEditor.Pipelines.SaveRichTextContent;

namespace MyActiveCommerce.Pipelines.SaveRichTextContent
{
    public class AddParagraphTagIfMissing
    {
        public void Process(SaveRichTextContentArgs args)
        {
            //when pasting plain text only, paragraph tags are initially omitted.
            string bodyContent = args.Content;
            if (bodyContent.Length > 0 && bodyContent.ToLower().IndexOf("<p>") == -1 && !bodyContent.StartsWith("<"))
            {
                args.Content = "<p>" + bodyContent + "</p>";
            }
        }
    }
}
