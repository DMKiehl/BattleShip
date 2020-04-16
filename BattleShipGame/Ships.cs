using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGame
{
    class Ships
    {
        //member variables
        public string ShipType { get; set; }

        public int SpaceSize { get; set; }
        public List<Ships> ShipChoices;
       
        //constructors
        public Ships()
        {
            ShipChoices = new List<Ships>
            {
                new Ships {ShipType = "Destroyer", SpaceSize = 2},
                new Ships {ShipType = "Submarine", SpaceSize = 3},
                new Ships {ShipType = "Battleship", SpaceSize = 4},
                new Ships {ShipType = "Aircraft Carrier", SpaceSize = 5},
            };
          
        }

        //member methods


    }
}
