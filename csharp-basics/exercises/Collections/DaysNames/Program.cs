var waitingForInput = true;
while (waitingForInput)
{
    Console.WriteLine("Input a date in YYYY MM DD format");
    var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    var date = new DateTime(input[0], input[1], input[2]);
    Console.WriteLine($"{string.Join('-', input)} is a {date.DayOfWeek}");
}