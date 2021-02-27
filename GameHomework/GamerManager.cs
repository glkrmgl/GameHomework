using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {

                Console.WriteLine(" Yeni Oyuncu Eklendi ! ");
            }
            else
            {
                Console.WriteLine(" Yeni Oyuncu Ekleme İşlemi Başarısız ! ");
                    
            }

        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(" Oyuncu Kaydı Silindi ! ");
        }

        
    }
}
