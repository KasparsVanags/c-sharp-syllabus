public class Owl : Bird {
    
    public override void makeSound() {
        Console.WriteLine("-- owl specific sound --");
    }

    
    public override bool canFly() {
        return true;
    }
    
    public void lookSmart(){
        // look very smart
    }
}