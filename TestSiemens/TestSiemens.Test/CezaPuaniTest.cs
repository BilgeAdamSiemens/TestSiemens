using System;
using NUnit.Framework;
namespace TestSiemens.Test
{
    [TestFixture]
    public class CezaPuaniTest
    {
        private CezaPuani _HSP;

        [SetUp]
        public void SetUp()
        {
            //Arrange
            _HSP = new CezaPuani();
        }

        [Test]
        [TestCase(-10)]
        [TestCase(301)]
        public void CezaPuaniHesaplama_SpeedIsOutOfRange_ThrowArgumentOutOfRangeException
            (int speed)
        {
            //Assert
            Assert.That(
                () => _HSP.CezaPuaniHesaplama(speed),
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>()
            );
        }

        [Test]
        [TestCase(0,0)]
        [TestCase(64, 0)]
        [TestCase(65, 0)]
        [TestCase(66, 0)]
        [TestCase(70, 0)]
        [TestCase(255, 37)]
        public void CezaPuaniHesaplama_WhenCalled_ReturnPenaltyPoint
            (int speed, int expectedResult)
        {
            //Act
            var penaltyPoint = _HSP.CezaPuaniHesaplama(speed);

            Assert.That(penaltyPoint, Is.GreaterThanOrEqualTo(expectedResult));
        }

    }   
}
