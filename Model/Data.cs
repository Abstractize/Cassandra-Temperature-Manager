public class Temperature{
    float temp;
    static int id = 0;
    public float Temp { get => temp; set => temp = value; }
    public static int Id { get => ++id; set => id = value; }

    public Temperature(float temp){
        this.temp = temp;
    }
}