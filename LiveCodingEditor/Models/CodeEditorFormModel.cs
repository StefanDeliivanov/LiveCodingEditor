namespace LiveCodingEditor.Models
{
    using System.ComponentModel.DataAnnotations;

    using static Data.DataConstants;

    public class CodeEditorFormModel
    {
        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage = htmlCodeAreaRequiredErrorMessage)]
        [StringLength(htmlExampleCodeMaxLength, ErrorMessage = htmlCodeLengthErrorMessage)]
        public string CodeText { get; set; }

        public string QueryType { get; set; }
    }
}