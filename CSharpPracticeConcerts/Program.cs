using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeConcerts
{
    public class MainClass
    {
        static void Main(String[] args)
        {
            //This class uses the Concert class that you are to create. It takes in the name headliner, date, stage, and ticket price.
            //You will be able to add as many openers as needed.
            //Calling the printInfo method for any given concert should output text that matches what I sent. Have fun!

            // ONE OK ROCK CONCERT
            Concert oneOkRock = new Concert("ONE OK ROCK", "10/1/2020", "Crofoot Ballroom", 50f); //making a new concert object takes in name of headliner, date of show, stage name and ticket prices

            oneOkRock.addOpener("Simple Plan"); //Adding openers, easiest way is to probably use an ArrayList of Strings
            oneOkRock.addOpener("5 Seconds of Summer");

            oneOkRock.printInfo(); //Prints all info to the console


            //YUNGBLUD CONCERT
            Concert yungblud = new Concert("Yungblud", "11/15/2020", "Pike Room", 20f);

            yungblud.addOpener("Saint Phnx");
            yungblud.addOpener("Halsey but she's in disguise");

            yungblud.printInfo();

        }
    }
}

