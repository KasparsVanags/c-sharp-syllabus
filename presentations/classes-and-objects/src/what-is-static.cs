class Car
{
    public static int Counter = 0;
    private string _brand;

    public Car(string brand)
    {
        this._brand = brand;
        Car.Counter++;
    }

    public static int countOfCarsCreated()
    {
        return Car.Counter;
    }
}

new Car("Audi");
new Car("Nissan");

Console.WriteLine(Car.Counter);
Console.WriteLine(Car.countOfCarsCreated());