using NUnit.Framework;
using System.Linq;

namespace TestSiemens.Test
{
    [TestFixture]
    [Author("Omur UCUM", "omur.ucum@bilgeadam.com")]
    class MathTest
    {
        private Math _math;

        static object[] DivideCases =
            {
                new object[] { 12, 3, 4 },
                new object[] { 12, 2, 6 },
                new object[] { 12, 4, 3 }
            };

        [SetUp]
        public void SetUp()
        {
            //Arrange
            _math = new Math();
        }

        [Test]
        public void Add_XPlusY_ReturnsExpectedResult()
        {
            //Act
            var result = _math.Add(3, 3);

            //Assert
            Assert.That(result, Is.EqualTo(6));

        }



        [Test]
        //[TestCase(1)] aktif edersen metoda parametre eklemeyi unutma (int expectedResult)
        public void GetOddNumbers_IsThereAnyOddNumberOrNumbers_ReturnOddNumber()
        {
            //Act
            var result = _math.GetOddNumbers(6);

            //Assert
            //Assert.That(result, Is.Not.Empty);
            //Assert.That(result.Count(), Is.EqualTo(2));

            //Assert.That(result, Does.Contain(expectedResult));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));
            //Assert.That(result, Does.Not.Contain(6));

            //Assert.That(result, Is.Ordered);
            //Assert.That(result, Is.Unique);

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));
        }

        [Test]
        [TestCase(8, 5, 8)]
        [TestCase(12, 21, 21)]
        [TestCase(61, 36, 61)]
        //[Ignore("Alihan istedi diye iptal ettik")]
        public void Max_WhenCalled_ReturnsTheGreatest(int a, int b, int expectedResult)
        {
            //Act
            var result = _math.Max(a,b);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        /* 3 farkli metod tanimlamaktansa yukardaki gibi
         * tek bir metod tanimlayarak test sayisini azalttik.
        [Test]
        public void Max_IfFirstIsMax_RetunrsTrue()
        {

        }

        [Test]
        public void Max_IfSecondIsMax_RetunrsTrue()
        {

        }

        [Test]
        public void Max_IfNumbersIsEqual_RetunrsTrue()
        {

        }
        */
    }
}
