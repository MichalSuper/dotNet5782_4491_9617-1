﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IBL
{
    namespace BO
    {
        public struct Station
        {
            /// <summary>
            /// properties
            /// </summary>
            public int Id { get; set; }
            public int Name { get; set; }
            public double Longitude { get; set; }
            public double Lattitude { get; set; }
            public int ChargeSlots { get; set; }
            /// <summary>
            /// to string
            /// </summary>
            public override string ToString()
            {
                return "Station: Id: " + Id + " Name: " + Name + " Longitude: " + DalObject.DalObject.Lng(Longitude) + " Lattitude: " + DalObject.DalObject.Lat(Lattitude) + " Charge Slots: " + ChargeSlots;
            }

        }
    }
}