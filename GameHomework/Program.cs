using System;

namespace GameHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewUserValidation());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                NickName = "xyzw",
                FirstName = "qwerty",
                LastName = "asdfg",
                Mail = "1234@tr.com",
                TcNum = 123456789,
                BirthYear = 19

            });

            OrderManager orderManager = new OrderManager();
            GameManager gameManager = new GameManager();
            KampanyaManager kampanyaManager = new KampanyaManager();

            Games game1 = new Games();
            game1.GameId = 1;
            game1.GameName = "Satranç";
            game1.GamePrice = 150;
            gameManager.Ekle(game1);
            Console.WriteLine("---------------------------");
            Console.WriteLine("");


            Games game2 = new Games();
            game2.GameId = 2;
            game2.GameName = "Mangala";
            game2.GamePrice = 200;
            gameManager.Ekle(game2);
            Console.WriteLine("---------------------------");
            Console.WriteLine("");

            Games game3 = new Games();
            game3.GameId = 3;
            game3.GameName = "Go";
            game3.GamePrice = 100;
            gameManager.Ekle(game3);
            Console.WriteLine("---------------------------");
            Console.WriteLine("");

            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.NickName = "Muhibbi";
            gamer1.FirstName = "Kanuni Sultan Süleyman";
            gamer1.LastName = "Kanuni";
            gamer1.Mail = "muhteşem@gmail.com";
            gamer1.TcNum = 149400046;
            gamer1.BirthYear = 1494;
            gamerManager.Add(gamer1);
            
            Console.WriteLine("Oyuncu "+gamer1.NickName+" kaydedildi ! ");
            Console.WriteLine("");
            Console.WriteLine("---------------------------");

            Gamer gamer2 = new Gamer();
            gamer2.Id = 2;
            gamer2.NickName = "Avni";
            gamer2.FirstName = "Fatih Sultan Mehmet";
            gamer2.LastName = "Fatih";
            gamer2.Mail = "istanbulfatihi@gmail.com";
            gamer2.TcNum = 143200030;
            gamer2.BirthYear = 1432;
            gamerManager.Add(gamer2);
            Console.WriteLine("Oyuncu " + gamer2.NickName + " kaydedildi ! ");
            Console.WriteLine("");
            Console.WriteLine("---------------------------");

            Gamer gamer3 = new Gamer();
            gamer3.Id = 3;
            gamer3.NickName = "Selimi";
            gamer3.FirstName = "Yavuz Sultan Selim";
            gamer3.LastName = "Yavuz";
            gamer3.Mail = "yavuz.sultan@gmail.com";
            gamer3.TcNum = 147000008;
            gamer3.BirthYear = 1470;
            gamerManager.Add(gamer3);
            Console.WriteLine("Oyuncu " + gamer3.NickName + " kaydedildi ! ");
            Console.WriteLine("");
            Console.WriteLine("---------------------------");

            

            Kampanya kampanya1 = new Kampanya();
            kampanyaManager.KampOner(kampanya1);
            Console.WriteLine(kampanya1.KampanyaName);
            kampanya1.KampanyaId = 01;
            kampanya1.KampanyaKodu = 101;
            kampanya1.KampanyaName = "İlk Kayıtta % 10 İndirim !";
            Console.WriteLine(" Tebrikler %10 indiriim kazandınız ! ");
            Console.WriteLine("*****************************");

            Kampanya kampanya2 = new Kampanya();
            kampanyaManager.KampOner(kampanya2);
            Console.WriteLine(kampanya2.KampanyaName);
            kampanya2.KampanyaId = 02;
            kampanya2.KampanyaKodu = 102;
            kampanya2.KampanyaName = "Bir Oyun Alana 2. Oyun %35 İndirimli !";
            Console.WriteLine(" Sana özel öneri: 2. oyun %35 indirimli ! ");
            Console.WriteLine("*****************************");

            Orders order1 = new Orders();
            order1.OrderId = 001;
            order1.GameId = 1;
            order1.GameName = "Satranç";
            order1.GamePrice = 150;
            order1.Id = 1;
            order1.NickName = "Muhibbi";
            orderManager.OrderEkle(order1, gamer1);
            Console.WriteLine("");

            Orders order2 = new Orders();
            order2.OrderId = 002;
            order2.GameId = 2;
            order2.GameName = "Mangala";
            order2.GamePrice = 200;
            order2.Id = 2;
            order2.NickName = "Avni";
            orderManager.OrderEkle(order2, gamer2);
            Console.WriteLine("");

            Orders order3 = new Orders();
            order3.OrderId = 003;
            order3.GameId = 3;
            order3.GameName = "Go";
            order3.GamePrice = 100;
            order3.Id =3;
            order3.NickName = "Selimi";
            orderManager.OrderEkle(order3, gamer3);
            Console.ReadLine();

        }
    }
}
