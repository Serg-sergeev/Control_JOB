namespace ProgramClass
{

    public static class UserInput
    {

        public static string inputText(string text)
        {

            Console.WriteLine(text);

            string? input = Console.ReadLine()!;

            return input;

        }

    }

}
