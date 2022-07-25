public class InstanceOfExample {
    public static void main(String[] args) {
        Animal animal = new Eagle();
        Console.WriteLine(animal is Animal);
        //true
        Console.WriteLine(animal is Bird);
        //true
        Console.WriteLine(animal is Eagle);
        //true
        Console.WriteLine(animal is Owl);
        //false
    }
}