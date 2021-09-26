namespace LiveCodingEditor.Services
{
    using System;
    using LiveCodingEditor.Data.Models;
    using Data;

    public class HtmlService : IHtmlService
    {
        private readonly LiveCodingEditorDbContext data;

        public HtmlService(LiveCodingEditorDbContext data)
        {
            this.data = data;
        }

        public bool Add(string text)
        {
            try
            {
                var example = new HtmlExample
                {
                    Id = Guid.NewGuid().ToString(),
                    CodeText = text,
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow
                };

                data.HtmlExamples.Add(example);
                data.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}