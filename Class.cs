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

        public static void PrintStringArray(string[] array)
        {
            Console.WriteLine(array.Length);
            for(int i = 0; i < array.Length - 2; i++)
            {

                Console.Write(array[i] + ", ");
        
            }

            Console.Write(array[array.Length - 1]);

        }

        public static string[] GetArrayOfInputUser(string input, string? separator = " ")
        {

            string[] array = input.Split(separator);
            Console.WriteLine(String.Join(",", array));
            return array;

        }

        public static string[] GetArrayWithTextMoreFreeChar(string[] array, int number = 3)
        {

            string resultText = "";

            foreach (var elem in array)
            {
                if (elem.Length <= number)
                {
                    resultText += elem + " ";
                }
            }

            string[] resultArray = resultText.Split(" ");
            Console.WriteLine(resultArray.Length);
            Console.WriteLine(String.Join(",", array));
            return resultArray;

        }

    }

}
