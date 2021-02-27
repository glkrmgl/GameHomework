using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework
{
    class Gamer:Games
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public long TcNum { get; set; }
        public int BirthYear { get; set; }


    }
}
