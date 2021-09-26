namespace LiveCodingEditor.Models
{
    using System.ComponentModel.DataAnnotations;

    using static Data.DataConstants;

    public class CodeEditorFormModel
    {
        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage = htmlCodeAreaRequiredErrorMessage)]
        public string CodeText { get; set; }
    }
}