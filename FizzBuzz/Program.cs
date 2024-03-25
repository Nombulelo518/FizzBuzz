
Greetings("Thando");
Greetings("Scelo");
Console.WriteLine("First Run");
FizzBuzz(1, 6);

Console.WriteLine("");
Console.WriteLine("Second Run");
FizzBuzz(1, 30);

static void Greetings(string name)
{
    Console.WriteLine($"Hello {name}");
}
static void FizzBuzz(int StartIndex, int EndIndex)
{

    for (var count = StartIndex; count < EndIndex; count++)
    {
        if (count % 3 == 0 && count % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (count % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (count % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(count);
        }
    }

}