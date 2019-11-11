using ArduinoUploader.Hardware;
using ArduinoDriver;
using System.Collections.Generic;

public class ArduinoGetter{
    private const ArduinoModel AttachedArduino = ArduinoModel.UnoR3;
    static ArduinoDriver.ArduinoDriver driver;
    static ArduinoGetter getter;
    public static List<Temperature> data = new List<Temperature>();
    public static ArduinoGetter Singleton(){
        if (getter == null)
            getter = new ArduinoGetter();
        return getter;
    }
    static ArduinoGetter(){
        //driver = new ArduinoDriver.ArduinoDriver(AttachedArduino, true);        
    }
    public static void GetData(){
        float t = 0;
        // Read
        Temperature temp = new Temperature(t);
        DataFiller.FillDataBase(temp);
    }  
}
