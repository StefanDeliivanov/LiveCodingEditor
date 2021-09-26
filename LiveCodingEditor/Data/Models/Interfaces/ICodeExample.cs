namespace LiveCodingEditor.Data.Models.Interfaces
{
    using System;

    // Provides scalability if we need to implement CSS, JS or other code example entities
    public interface ICodeExample
    {
        public string CodeText { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }
    }
}