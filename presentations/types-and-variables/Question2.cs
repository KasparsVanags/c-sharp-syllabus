static void Main(string[] args)
{
    {
        String name = "CODELEX";
        Console.WriteLine("programing @" + name);
    }
    name = "codelex";
    Console.WriteLine("programing @" + name);
    // What will be the output?
    // 1. programming @CODELEX ↵
    //  programming @codelex
    // 2. programming @CODELEX ↵
    //  programming @CODELEX
    // 3. runtime error
    // 4. compilation error
}