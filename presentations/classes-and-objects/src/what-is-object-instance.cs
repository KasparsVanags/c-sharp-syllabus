class Car
{
    private string _brand;

    public Car(string brand)
    {
        this._brand = brand;
    }

    public void drive()
    {
        //do stuff
    }
}

var cars = new Car[] {new Car("Audi"), new Car("Nissan"), new Car("Volvo")};
foreach (var car in cars)
{
    car.drive();
}