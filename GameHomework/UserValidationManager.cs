using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id==1 && gamer.NickName=="xyzw"  &&  gamer.FirstName == "qwerty" && gamer.LastName == "asdfg"&&
                gamer.Mail == "1234@tr.com" && gamer.TcNum == 123456789 && gamer.BirthYear == 1900)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}
