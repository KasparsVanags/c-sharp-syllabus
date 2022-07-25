class Car
{
    private string _brand;
    private bool _driving;
    public Car(string brand)
    {
        this._brand = brand;
        this._driving = false;
    }

    public bool driving
    {
        get => this._driving;
    }

    public void drive()
    {
        this._driving = true;
    }

    public void stop()
    {
        this._driving = false;
    }
}

var car = new Car("Audi");
Console.WriteLine(car.driving); //false
car.drive();
Console.WriteLine(car.driving); //true