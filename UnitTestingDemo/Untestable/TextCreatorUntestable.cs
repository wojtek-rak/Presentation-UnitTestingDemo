using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UnitTestingDemo.Untestable
{
    public class TextCreatorUntestable
    {
        public void CreateText(string title, string description)
        {
            if (title == "") throw new EmptyTitleException();

            var _sb = new StringBuilder();

            _sb.AppendLine(title);
            _sb.AppendLine(description);

            using (StreamWriter outputFile = new StreamWriter("CreatedText.txt"))
            {
                outputFile.Write(_sb.ToString());
            }
        }
    }
}
