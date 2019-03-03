using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Internal;
using UnitTestingDemo.CloseToBeTestable;

namespace UnitTestingDemo.Tests.CloseToBeTestable
{
    [TestFixture]
    public class TextCreatorCloseTests
    {
        [Test]
        public void AddTitle_StringAppendInSB_ProperAddLine()
        {
            var textCreator = new TextCreatorClose();

            var title = "Title";
            textCreator.AddTitle(title);
            var expected = "Title\r\n";

            Assert.AreEqual(expected, textCreator.Sb.ToString());
        }

        [Test]
        public void AddDescription_StringAppendInSB_ProperAddLine()
        {
            var textCreator = new TextCreatorClose();

            var desc = "Desc";
            textCreator.AddDescription(desc);
            var expected = "Desc\r\n";

            Assert.AreEqual(expected, textCreator.Sb.ToString());
        }

        [Test]
        public void ExportText_NotEmptySB_ProperlyReturnedTextAndClearSB()
        {
            var textCreator = new TextCreatorClose();

            var txt = "Hello";
            textCreator.Sb.Append(txt);
            var result = textCreator.ExportText();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(txt, result);
                Assert.AreEqual("", textCreator.ExportText());
            });
        }
    }
}
