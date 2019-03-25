using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using NUnit.Framework;
using UnitTestingDemo.Testable;

namespace UnitTestingDemo.Tests.Testable
{
    [TestFixture]
    public class FileCreatorTests
    {

        //Mock
        [Test]
        public void CreateText_NotEmptyTitle_ProperAddLine()
        {
            var mockTextCreator = new Mock<ITextCreator>();
            var fileCreator = new FileCreator(mockTextCreator.Object);

            var result = fileCreator.CreateText("NotEmptyTitle", "desc");

            mockTextCreator.Verify(m => m.ExportText(), Times.Once);
        }

        //Stub
        [Test]
        public void CreateText_NotEmptyTitle_ProperAddLine2()
        {
            var mockTextCreator = new Mock<ITextCreator>();
            mockTextCreator.Setup(x => x.ExportText()).Returns("Text");

            var fileCreator = new FileCreator(mockTextCreator.Object);

            var result = fileCreator.CreateText("NotEmptyTitle", "desc");

            Assert.AreEqual("Text", result);
        }

        //Fake
        [Test]
        public void CreateText_NotEmptyTitle_ProperAddLine3()
        {
            var fakeTextCreator = new FakeTextCreator();

            var fileCreator = new FileCreator(fakeTextCreator);

            var result = fileCreator.CreateText("NotEmptyTitle", "desc");

            Assert.AreEqual("Text", result);
        }

        [Test]
        public void CreateText_EmptyTitle_ThrowException()
        {
            var mockTextCreator = new Mock<ITextCreator>();
            var fileCreator = new FileCreator(mockTextCreator.Object);

            var title = "";

            Assert.Throws<EmptyTitleException>(() => fileCreator.CreateText(title, "desc"));
            mockTextCreator.Verify(m => m.ExportText(), Times.Never);
        }

        
    }

    public class FakeTextCreator : ITextCreator
    {
        public void AddTitle(string title)
        {
            //throw new NotImplementedException();
        }

        public void AddDescription(string description)
        {
            //throw new NotImplementedException();
        }

        public string ExportText()
        {
            return "Text";
        }
    }
}
