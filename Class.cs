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

    public static class ActionsWithArray
    {

        public static string[] GetArrayOfInputUser(string input)
        {

            string[] array = input.Split(",");
            
            return array;

        }

        public static string[] GetArrayWithTextMoreFreeChar(string[] array, int number = 3)
        {

            string resultText = string.Empty;

            foreach (var elem in array)
            {
                if (elem.Length <= number)
                {
                    resultText += elem + " ";
                }
            }

            string[] resultArray = resultText.Split(" ");

            return resultArray;

        }

    }

}
