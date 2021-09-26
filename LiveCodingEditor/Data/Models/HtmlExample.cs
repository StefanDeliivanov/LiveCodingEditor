namespace LiveCodingEditor.Data.Models
{
    using System;
    using Data.Models.Interfaces;

    public class HtmlExample : ICodeExample
    {
        public string Id { get; set; }

        public string CodeText { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }
    }
}