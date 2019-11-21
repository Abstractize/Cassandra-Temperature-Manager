using System.IO.Ports;
using System.Collections.Generic;
using System;

public class ArduinoGetter{
    static SerialPort serialPort = new SerialPort();
    static ArduinoGetter getter;
    public static List<Temperature> data = new List<Temperature>();
    public static ArduinoGetter Singleton(){
        if (getter == null)
            getter = new ArduinoGetter();
        return getter;
    }
    static ArduinoGetter(){
        // Set port options
        serialPort.PortName = "/dev/cu.usbmodem14401";
        serialPort.BaudRate = 9600;

        // Connect the serial port
        serialPort.Open();
    }
    public static void GetData(){
        string o = serialPort.ReadLine();
        float t = 0;
        // Read
        Console.WriteLine(o);
        t = float.Parse(o);

        Temperature temp = new Temperature(t);
        DataFiller.FillDataBase(temp);
    }  
}
