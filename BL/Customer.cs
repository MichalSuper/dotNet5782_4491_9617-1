﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IBL
{
    namespace BO
    {
        public class Customer
        {
            /// <summary>
            /// properties
            /// </summary>
            public int Id { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public Location LocationC { get; set; }
            public IEnumerable<ParcelInCustomer> FromCustomer { get; set; }
            public IEnumerable<ParcelInCustomer> ToCustomer { get; set; }
            /// <summary>
            /// to string
            /// </summary>
            public override string ToString()
            {
                string fromC = "", toC = "";
                foreach (ParcelInCustomer p in FromCustomer)
                {
                    fromC += p.ToString();
                }
                foreach (ParcelInCustomer p in ToCustomer)
                {
                    toC += p.ToString();
                }
                return "Id:"+Id+"\nName:"+Name+"\nPhone:"+Phone+"\nLocation:"+LocationC+"\nParcel from customer:"+fromC+ "\nParcel to customer:" + toC;
            }

        }
    }
}
