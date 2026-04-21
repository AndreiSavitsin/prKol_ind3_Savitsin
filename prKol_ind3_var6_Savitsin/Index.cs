using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prKol_ind3_var6_Savitsin
{
    public class Index
    {
        private Stack<string> words = new Stack<string>();
        private Stack<int> pages = new Stack<int>();

        public void Add(string word, int pageNumber)
        {
            words.Push(word);
            pages.Push(pageNumber);
        }

        string filename = "file.txt";

        public void LoadFromFile()
        {
            words.Clear();
            pages.Clear();

            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                if (line != "")
                {
                    string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string word = parts[0];

                    for (int i = 1; i < parts.Length; i++)
                    {
                        int page;
                        if (int.TryParse(parts[i], out page))
                        {
                            words.Push(word);
                            pages.Push(page);
                        }
                    }
                }
            }
        }

        public string ShowAll()
        {
            string result = "";

            string[] wordsArray = words.ToArray();
            int[] pagesArray = pages.ToArray();

            for (int i = 0; i < wordsArray.Length; i++)
            {
                result = result + wordsArray[i] + ": " + pagesArray[i] + "\r\n";
            }

            if (result == "") result = "Пусто";

            return result;
        }

        public string Find(string searchWord)
        {
            string result = "";
            string[] wordsArray = words.ToArray();
            int[] pagesArray = pages.ToArray();

            for (int i = 0; i < wordsArray.Length; i++)
            {
                if (wordsArray[i].ToLower() == searchWord.ToLower())
                {
                    result = result + wordsArray[i] + ": " + pagesArray[i] + "\r\n";
                }
            }

            if (result == "")
                return "Не найдено";

            return result;
        }

        public bool Delete(string deleteWord)
        {
            Stack<string> tempWords = new Stack<string>();
            Stack<int> tempPages = new Stack<int>();
            bool found = false;

            while (words.Count > 0)
            {
                string w = words.Pop();
                int p = pages.Pop();

                if (w.ToLower() != deleteWord.ToLower())
                {
                    tempWords.Push(w);
                    tempPages.Push(p);
                }
                else
                {
                    found = true;
                }
            }

            while (tempWords.Count > 0)
            {
                words.Push(tempWords.Pop());
                pages.Push(tempPages.Pop());
            }

            return found;
        }
    }
}