using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UnitTestingDemo.CloseToBeTestable
{
    public class FileCreatorClose
    {
        public string CreateText(string title, string description)
        {
            if (title == "") throw new EmptyTitleException();

            var textCreator = new TextCreatorClose();
            textCreator.AddTitle(title);
            textCreator.AddDescription(description);
            return textCreator.ExportText();
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
