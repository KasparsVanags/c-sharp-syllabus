public class PrePostIncrement {
    public static void Main(string[] args) {
        int a = 21;
        int b = 35;
        int sum = a++ + ++b;
        Console.WriteLine("sum = " + sum);
        // 1. 56
        // 2. 57
        // 3. 58
        // 4. compilation error
    }
}
