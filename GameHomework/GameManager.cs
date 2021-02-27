using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework
{
    class GameManager : IGameService
    {
        public void Ekle(Games games)
        {
            Console.WriteLine(games.GameName + " Oyunu Listenize Eklendi ! ");
        }

        public void Sil(Games games)
        {
            Console.WriteLine(games.GameName+ " Oyunu Listenizden Silindi ! ");
        }
    }
}
