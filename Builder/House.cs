using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{


    public  class House
    {
        public string Foundation { get; set; }
        public string Structure { get; set; }
        public int NumberOfRooms { get; set; }


        public override string ToString()
        {
            return $"House with {Foundation}, {Structure}, {NumberOfRooms} rooms.";
        }

    }
}
