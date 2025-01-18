import java.net.CacheRequest;

public class Main
{
    public static void main(String[] args)
    {
        //Reference Variable
        //Reference Variable can be initialized in more than one line typically in two lines.
        //The variable car1 is a reference variable of type Car, meaning it can hold the reference to an object of type Car.
        Car car1;
        //This line is used to create an object in heap and store the address reference to car1
        car1 = new Car();

        car1.setName("Toyota");
        car1.setYearModel(2017);

        System.out.println("car1 name is " + car1.getName());
        System.out.println("car1 year model is " + car1.getYearModel());

        //Reference Variable can initialized in only one line.
        Car car2 = new Car();
        car2.setName("Hyunadi");
        car2.setYearModel(-1997);
        System.out.println("car2 name is " + car2.getName());
        System.out.println("car2 YearModel is " + car2.getYearModel());
    }
}