public class ArduinoGetter{
    private const ArduinoModel AttachedArduino = ArduinoModel.UnoR3;
    static var driver;
    public static ArduinoGetter Singleton(){
        if (driver == null)
            driver = new ArduinoDriver(ArduinoModel.UnoR3, true);
        return getter;
    }  
}
