namespace LiveCodingEditor.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Data.Models.Interfaces;

    using static Data.DataConstants;

    public class HtmlExample : ICodeExample
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(htmlExampleCodeMaxLength)]
        public string CodeText { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime ModifiedOn { get; set; }
    }
}