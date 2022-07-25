public class Eagle : Bird {

    public override void makeSound() {
        Console.WriteLine("-- eagle specific sound --");
    }

    
    public override bool canFly() {
        return true;
    }

    public void attack() {
        // dangerously attack enemy
    }
}