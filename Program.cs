using System;
using DAY2.Libraries;

namespace DAY2{
    class Program
    {
        public static void Main(string[] args)
        {

            SignalProcessor signalConverter = new SignalProcessor();

            double InputPower = 500;
            double reffPower = 0.001;
            double PowerInDecibels = signalConverter.PowerToDecibels(InputPower, reffPower);
            double DecibelOfPower = signalConverter.decibelsToPower(PowerInDecibels, reffPower);

            Console.WriteLine(InputPower + "Watts to Decibels is: " + PowerInDecibels);
            Console.WriteLine(PowerInDecibels + " The Decibels is "+ DecibelOfPower+ " in Power");

        }
        

    }
}
