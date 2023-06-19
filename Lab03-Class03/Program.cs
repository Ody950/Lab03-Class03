using System;
using System.ComponentModel.Design;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace Lab3
{
    public class Challenge
    {
        static void Main(string[] args)
        {
            string path = "../../../words.txt";
            int[] arr = new int[] { 1, 2, 5, 3, 4, 5 };
          
            Challenge1(arr);
            Challenge2(arr);
            Challenge3();
            Challenge4(arr);
            Challenge5(arr);
            Challenge6(path);
            Challenge7(path);
            Challenge8(path);
            Challenge9();
        }



        public static int Challenge1(int[] arr)
        {
            Console.WriteLine("Please enter 3 numbers: ");
            string input = Console.ReadLine();
            arr = Array.ConvertAll(input.Split(' '), int.Parse);
           
            if (arr.Length < 3)
            {
                return 0;
            }

            int result = 1;
            for (int i = 0; i < 3; i++)
            {
                if (!int.TryParse(arr[i].ToString(), out int parsedNumber))
                {
                    parsedNumber = 1;
                }
                result *= parsedNumber;
            }
            Console.WriteLine(result);
            return result;
        }


        //----------------start------------Challenge2--------------------------------------------------------
        //----------------start------------Challenge2--------------------------------------------------------



  public static int Challenge2(int[] numbers)
{
    Console.WriteLine("Enter a number between 2-10");
    int size = Convert.ToInt32(Console.ReadLine());
    if (size >= 2 && size <= 10)
    {
                numbers = new int[size];
            }
    else
    {
        Console.WriteLine("Input is not correct");
      
    }

    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine($"Enter number: {i + 1} of {numbers.Length}");
        bool isNumber = false;
        while (!isNumber)
        {
            string input = Console.ReadLine();
            isNumber = int.TryParse(input, out int number);
            if (isNumber && number >= 0)
            {
                numbers[i] = number;
                sum += numbers[i];
            }
            else
            {
                Console.WriteLine("Enter a positive number.");
                isNumber = false;
            }
        }
    }

    int Average = 0;
    if (size > 0)
    {
        Average = sum / size;
    }
    Console.WriteLine(Average);
    return Average;
}


//----------------END------------Challenge2--------------------------------------------------------

//----------------END------------Challenge2--------------------------------------------------------



public static void Challenge3()
            {
                int number, i, k, count;
                number = 5; 
                count = number - 1;
                for (k = 1; k <= number; k++)
                {
                    for (i = 1; i <= count; i++)
                        Console.Write(" ");
                    count--;
                    for (i = 1; i <= 2 * k - 1; i++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                count = 1;
                for (k = 1; k <= number - 1; k++)
                {
                    for (i = 1; i <= count; i++)
                        Console.Write(" ");
                    count++;
                    for (i = 1; i <= 2 * (number - k) - 1; i++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                Console.ReadLine();
            }



        public static int Challenge4(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("array is null or empty.");
            }

            var dict = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                if (dict.ContainsKey(number))
                {
                    dict[number]++;
                }
                else
                {
                    dict[number] = 1;
                }
            }

            var theMax = 0;
            var TheNumber = numbers[0];

            foreach (var kvp in dict)
            {
                if (kvp.Value > theMax)
                {
                    theMax = kvp.Value;
                    TheNumber = kvp.Key;
                }
            }
            Console.WriteLine(TheNumber);
            return TheNumber;
        }



        public static int Challenge5(int[] numbers)
        {
            int x = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= x)
                {
                    x = numbers[i];
                }
            }
            Console.WriteLine(x);
            return x;
        }



        static void Challenge6(string path)
        {
            Console.WriteLine("Enter any words:");
            string newLine = Console.ReadLine();

            File.WriteAllText(path, newLine);
        }


        static void Challenge7(string path)
        {

            Console.WriteLine(File.ReadAllText(path));

        }



        static void Challenge8(string path)
        {
            string[] lines = File.ReadAllLines(path);

            if (lines.Length >= 2)
            {
                string[] words = lines[0].Split(' ');
                string NewWord = words[0];
                words[0] = "";

                lines[1] = string.Join(" ", NewWord);
                File.WriteAllLines(path, lines);
                Console.WriteLine(NewWord);
            }
            else
            {
                string[] words = lines[0].Split(' ');
                string NewWord = words[0];
                words[0] = "";

                lines[0] = string.Join(" ", NewWord);
                File.WriteAllLines(path, lines);
                Console.WriteLine(NewWord);
            }
           
        }


        public static string[] Challenge9()
        {
            Console.WriteLine("input a sentence");

            string input = Console.ReadLine();

            string[] words = input.Split(' ');
            string[] result = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != null)
                {
                    result[i] = $@"""{words[i]}"": {words[i].Length}";
                }
                else
                {
                    result[i] = "null";
                }
            }
            Console.Write("Output: ");
            Console.Write("[");
            Console.Write(string.Join(",", result));
            Console.WriteLine("]");
            return result;
        }


    }
}
        

