using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UnitTestingDemo.Testable
{
    public class FileCreator
    {
        private readonly ITextCreator _textCreator;

        public FileCreator(ITextCreator textCreator)
        {
            this._textCreator = textCreator; 
        }

        public string CreateText(string title, string description)
        {
            if (title == "") throw new EmptyTitleException();

            _textCreator.AddTitle(title);
            _textCreator.AddDescription(description);
            return _textCreator.ExportText();
        }

        public void SaveFile(string textToSave)
        {
            using (StreamWriter outputFile = new StreamWriter("CreatedText.txt"))
            {
                outputFile.Write(textToSave);
            }
        }
    }
}
