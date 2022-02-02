using System;
using System.Collections.Generic;

namespace CSharpPracticeConcerts
{
    public class Concert
    {
        private string headlinerName;
        private string concertDate;
        private string concertVenue;
        private float ticketPrice;

        List<string> openerNames = new List<string>();

        public Concert(string headlinerName, string concertDate, string concertVenue, float ticketPrice)
        {
            this.headlinerName = headlinerName;
            this.concertDate = concertDate;
            this.concertVenue = concertVenue;
            this.ticketPrice = ticketPrice;
        }//end ctor

        public void addOpener(string openerName)
        {
            openerNames.Add(openerName);

        }//end addOpener

        public void printInfo()
        {
            Console.WriteLine(
                "=====THE CROFOOT PRESENTS=====\n\n" + headlinerName +
                " \n\n" + "With Supporting Acts: \n\n");

            foreach (var openerNames in openerNames)
            {
                Console.WriteLine(openerNames);
            }

            Console.WriteLine("\n\n" + "Show Details:" + "\n\n" + concertDate + ", " +
            concertVenue + " at The Crofoot Complex.  " + "$" + ticketPrice);

            Console.ReadLine();
        }//end print info

    }//end public class

}