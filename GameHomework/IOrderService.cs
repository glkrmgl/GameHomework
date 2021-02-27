using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework
{
    interface IOrderService
    {
        void OrderEkle(Orders orders, Gamer gamer);
        void OrderSil(Orders orders, Gamer gamer);


    }
}
