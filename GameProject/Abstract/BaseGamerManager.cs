using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("Kayıt eklendi : " + gamer.FirstName);
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
