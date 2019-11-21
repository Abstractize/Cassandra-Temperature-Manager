using System;

namespace Cassandra_Temperature_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            ArduinoGetter ard = ArduinoGetter.Singleton();
            DataFiller data = DataFiller.Singleton();
            DateTime stopTime = DateTime.Now.AddHours(3); 
            while (DateTime.Now < stopTime)
                ArduinoGetter.GetData();
        }
    }
}
