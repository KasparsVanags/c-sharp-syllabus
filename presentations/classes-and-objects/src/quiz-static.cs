class Car
{
    private string _brand;

    public Car(string brand)
    {
        _brand = brand;
    }

    public static void stop()
    {
        Console.WriteLine($"{this._brand} is being stopped");
    }
}

Car audi = new Car("Audi");
audi.stop();
// What will be the output?
// 1. "Audi is being stopped..."
// 2. "this.brand is being stopped..."
// 3. error will be thrown
// 4. ""