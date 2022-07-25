    class Car
    {
        string brand;
        public Car(string brand)
        {
            this.brand = brand;
        }

        void drive()
        {
            //do stuff
        }
    }

    class Plane
    {
        void fly()
        {
            //do stuff
        }
    }

    Car car = new Car("car");
    car.drive();

    Plane plane = new Plane();
    plane.fly();