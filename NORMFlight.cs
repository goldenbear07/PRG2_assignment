using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_Assignment
{
    class NORMFLight : Flight
    {
        public override double CalculateFees()
        {
            double extrafees = 0;
            if (Origin == "Singapore (SIN)")//departing flights
            {
                extrafees += 800;
            }
            else if (Destination == "Singapore (SIN)") //arriving flights
            {
                extrafees += 500;
            }

            double totalfees = 300 + extrafees; //300 is the Boarding gate base fee
            return totalfees;

        }

        public NORMFLight(string flightNumber, string origin, string destination, DateTime expectedTime, string status) : base(flightNumber, origin, destination, expectedTime, status)
        {

        }

        public override string ToString()
        {
            return base.ToString(); 
        }
    }
}
//im assuming you dont need to consider the special codes cus this is for normal flights


            /////////////////////////////////////////////////////////////////////////////

            //double discounts = 50; //defaults to 50 since this is a normal flight, no special req, hence discount is 50


            //string[] flights = File.ReadAllLines("flights.csv");
            //for (int i = 1; i < flights.Length; i++)
            //{

            //}

            //TimeSpan eleven = new TimeSpan(11, 0, 0); // 11:00 AM
            //TimeSpan nine = new TimeSpan(21, 0, 0); // 9:00 PM
            //if (ExpectedTime.TimeOfDay < eleven) 
            //{
            //    discounts += 110;
            //}

            //else if (ExpectedTime.TimeOfDay > nine)
            //{
            //    discounts += 110;
            //}


            



            //if (Origin == "Dubai (DXB)")
            //{
            //    discounts += 25;
            //}
            //else if (Origin == "Bangkok(BKK)")
            //{
            //    discounts += 25;
            //}
            //else if (Origin == "Tokyo (NRT)")
            //{
            //    discounts += 25;
            //}
            

            //return totalfees - discounts;
        //}//ending method brack

//    }//ending class brack
//}//ending ns brack
