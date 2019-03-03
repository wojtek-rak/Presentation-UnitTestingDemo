using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingDemo.Testable
{
    public class TextCreator : ITextCreator
    {
        public StringBuilder Sb = new StringBuilder();

        public void AddTitle(string title)
        {
            Sb.AppendLine(title);
            //Imagine that we have more logic
        }

        public void AddDescription(string description)
        {
            Sb.AppendLine(description);
            //Imagine that we have more logic
        }

        public string ExportText()
        {
            var exportedText = Sb.ToString();
            Sb.Clear();
            return exportedText;
        }
    }
}
