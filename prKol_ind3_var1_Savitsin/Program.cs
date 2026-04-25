using System;
using System.Collections;
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

                var numbers = from c in text where char.IsDigit(c) select c;
                ArrayList arraylist = new ArrayList();

                foreach (char c in text)
                {
                    if (char.IsDigit(c))
                    {
                        arraylist.Add(c);
                    }
                }

                Console.WriteLine("Числа в обратном порядке:");

                if (numbers.Count() == 0 || arraylist.Count == 0)
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
                    for (int i = arraylist.Count-1; i >= 0; i--)
                    {
                        Console.Write((char)arraylist[i]);
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
