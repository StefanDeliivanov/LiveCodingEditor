namespace LiveCodingEditor.Data
{
    public class DataConstants
    {
        public const string htmlCodeAreaRequiredErrorMessage = "The HTML code field cannot be empty!";
        public const string htmlCodeLengthErrorMessage = "The code example size cannot be more than 5MB. Please use less characters";
        public const int htmlExampleCodeMaxLength = 2500000; // 2.5 milion nvarchar's are equal to 5MB of text
    }
}