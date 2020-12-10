using NUnit.Framework;
using System;

namespace TestSiemens.Test
{
    [TestFixture]
    public class HtmlFormatterTest
    {
        private HtmlFormatter _HFT;

        [SetUp]
        public void SetUp()
        {
            //Arrange
            _HFT = new HtmlFormatter(); 
        }

        [Test]
        [TestCase("Siemens")]
        public void FormatAsBold_WhenCalled_ReturnsStrong(string param)
        {
            //Act
            var result = _HFT.FormatAsBold(param);
            //Assert
            //spesifik bir tanim
            Assert.That(result, Is.EqualTo("<strong>"+ param + "</strong>"));
            //daha genel bir hali asagidadir
            Assert.That(result, Does.Contain("<strong>"));
            Assert.That(result, Does.Contain(param));
            Assert.That(result, Does.Contain("</strong>"));
        }

    }
}
