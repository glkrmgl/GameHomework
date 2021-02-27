using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework
{
    class KampanyaManager : IKampanyaService
    {
        public void KampOner(Kampanya kampanya)
        {
            Console.WriteLine(" Size Özel Kampanyaları Görmek İçin Lütfen Tıklayın ! ");
        }

        public void KampSelect(Kampanya kampanya)
        {
            Console.WriteLine(" Seçtiğiniz Kampanya Siparişinize Uygulandı ! ");
        }
    }
}
