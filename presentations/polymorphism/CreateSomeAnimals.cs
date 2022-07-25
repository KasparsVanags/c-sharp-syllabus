public class CreateSomeAnimals {
    public static void main(string[] args) {
        List<Animal> animals = new List<Animal>();
            animals.Add(new Eagle());
            animals.Add(new Owl());
        
            animals.ForEach(animal => {
                animal.makeSound();
                // wont compile - animal.canFly()
            });
    }
}