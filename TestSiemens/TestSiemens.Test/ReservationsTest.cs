using NUnit.Framework;

namespace TestSiemens.Test
{
    [TestFixture]
    public class ReservationsTest
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservations = new Reservations();
            //Act
            var result = reservations.CanBeCancelledBy(new User { IsAdmin = true });
            //Assert
            //Assert.IsTrue(result);
            //Assert.That(result, Is.True);
            Assert.That(result == true);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingReservation_ReturnsTrue()
        {
            //Arrange => Test edecegimiz metodun ait oldugu sinifitan obje yaratma bolumu
            var user = new User();
            var reservations = new Reservations { MadeBy = user };

            //Act => yarattigimiz objeler uzerinden test edilecek olan metodlara ulasiriz
            var result = reservations.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUser_ReturnsFalse()
        {
            //Arrange
            var user = new User();
            var reservations = new Reservations { MadeBy = user };

            //Act
            var result = reservations.CanBeCancelledBy(new User());

            //Assert
            Assert.IsFalse(result);
        }
    }
}
