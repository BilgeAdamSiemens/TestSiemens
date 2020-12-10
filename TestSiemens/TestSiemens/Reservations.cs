using System;
using System.Collections.Generic;
using System.Text;

namespace TestSiemens
{
    public class Reservations
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            //return false;
            return (user.IsAdmin || MadeBy == user);
        }
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}
