using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class GamerManager : BaseGamerManager
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public override void Add(Gamer gamer)
        {
            if (_gamerCheckService.Validate(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                Console.WriteLine("Malesef");
            }
        }
    }
}
