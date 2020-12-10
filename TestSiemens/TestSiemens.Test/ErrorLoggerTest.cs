using System;
using NUnit.Framework;
namespace TestSiemens.Test
{
    [TestFixture]
    public class ErrorLoggerTest
    {

        private ErrorLogger _ErrorLogger;

        [SetUp]
        public void SetUp()
        {
            //Arrange
            _ErrorLogger = new ErrorLogger();
        }

        [Test]
        [TestCase("    ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            //Act
            //_ErrorLogger.Log("");
            //Assert
            Assert.That(() => _ErrorLogger.Log(error), Throws.ArgumentNullException);
        }


        [Test, MaxTime(2000)]
        [TestCase("Bir cisim yaklasiyor")]
        public void Log_ValidError_RaiseErrorMessage(string error)
        {
            var id = Guid.NewGuid();
            //Act
            _ErrorLogger.ErrorLogged += (sender, args) => { id = args; };
            _ErrorLogger.Log(error);

            //Assert
            Assert.That(id, Is.EqualTo(id));


        }
    }
}
