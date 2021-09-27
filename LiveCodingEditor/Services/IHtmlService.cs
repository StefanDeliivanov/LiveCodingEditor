namespace LiveCodingEditor.Services
{
    using LiveCodingEditor.Models;

    public interface IHtmlService
    {
        public string Add(string text);

        public bool CheckOriginal(string text);

        public string Edit(string id, string text);

        public CodeEditorFormModel GetModelById(string id);

        public bool IdExists(string id);
    }
}