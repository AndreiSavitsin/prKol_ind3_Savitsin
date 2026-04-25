using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

namespace prKol_ind3_var1_Savitsin
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "file.txt";
            if (File.Exists(filePath))
            {
                string text = File.ReadAllText(filePath);

                Stack<char> stack = new Stack<char>();
                var numbers = from c in text where char.IsDigit(c) select c;

                foreach (char c in text)
                {
                    if (char.IsDigit(c))
                    {
                        stack.Push(c);
                    }
                }

                Console.WriteLine("Числа в обратном порядке:");

                if (numbers.Count() == 0)
                {
                    Console.WriteLine("Нет чисел в файле");
                }
                else
                {
                    foreach (char c in numbers.Reverse())
                    {
                        Console.Write(c);
                    }
                    Console.WriteLine();
                    while (stack.Count > 0)
                    {
                        Console.Write(stack.Pop());
                    }
                }
            }
            else
            {
                Console.WriteLine("Текстовый файл не найден");
            }

            Console.ReadKey();
        }
    }
}
