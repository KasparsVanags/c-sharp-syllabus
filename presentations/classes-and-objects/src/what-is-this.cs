class Car
{
    private int _mileage;

    public void drive()
    {
        this._mileage++;
    }

    public void report()
    {
        Console.WriteLine($"Current mileage is {_mileage}km");
    }
}

var audi = new Car("Audi");
for (int i = 0; i < 100; i++)
{
    audi.drive();
}
audi.report(); //output?