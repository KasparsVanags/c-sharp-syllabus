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

var audi = new Car("Audi"); //first instance
audi.drive();

var nissan = new Car("Nissan"); //second instance
nissan.drive();