namespace LiveCodingEditor.Services
{
    using System;
    using System.Linq;
    using LiveCodingEditor.Data;
    using LiveCodingEditor.Data.Models;
    using LiveCodingEditor.Models;

    public class HtmlService : IHtmlService
    {
        private readonly LiveCodingEditorDbContext data;

        public HtmlService(LiveCodingEditorDbContext data)
        {
            this.data = data;
        }

        public string Add(string text)
        {
            var htmlExample = new HtmlExample
            {
                Id = Guid.NewGuid().ToString(),
                CodeText = text,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow
            };

            data.HtmlExamples.Add(htmlExample);
            data.SaveChanges();

            return htmlExample.Id;
        }

        public bool CheckOriginal(string text)
        {
            var htmlExample = this.data
                .HtmlExamples
                .Where(x => x.CodeText == text)
                .FirstOrDefault();

            if (htmlExample == null)
            {
                return true;
            }

            return false;
        }

        public string Edit(string id, string text)
        {
            var htmlExample = this.data.HtmlExamples.Find(id);
            htmlExample.CodeText = text;
            htmlExample.ModifiedOn = DateTime.UtcNow;

            data.SaveChanges();

            return htmlExample.Id;
        }

        public CodeEditorFormModel GetModelById(string id)
        {
            var htmlExample = this.data.HtmlExamples.Find(id);

            return new CodeEditorFormModel
            {
                Id = htmlExample.Id,
                CodeText = htmlExample.CodeText,
                QueryType = "Save"
            };
        }

        public bool IdExists(string id)
        {
            var htmlExample = this.data.HtmlExamples.Find(id);

            if (htmlExample == null)
            {
                return false;
            }
            return true;
        }
    }
}