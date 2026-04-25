using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prKol_ind3_var6_Savitsin
{
    public class Index
    {
        ArrayList wordsList = new ArrayList();
        ArrayList pagesList = new ArrayList();

        public void Add(string word, int pageNumber)
        {
            wordsList.Add(word);
            pagesList.Add(pageNumber);
        }

        string filename = "file.txt";

        public void LoadFromFile()
        {
            wordsList.Clear();
            pagesList.Clear();

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
                            wordsList.Add(word);
                            pagesList.Add(page);
                        }
                    }
                }
            }
        }

        public string ShowAll()
        {
            string result = "";

            for (int i = 0; i < wordsList.Count; i++)
            {
                result = result + wordsList[i] + ": " + pagesList[i] + "\r\n";
            }

            if (result == "") result = "Пусто";

            return result;
        }

        public string Find(string searchWord)
        {
            string result = "";

            for (int i = 0; i < wordsList.Count; i++)
            {
                string word = (string)wordsList[i];
                if (word.ToLower() == searchWord.ToLower())
                {
                    result = result + wordsList[i] + ": " + pagesList[i] + "\r\n";
                }
            }

            if (result == "")
                return "Не найдено";

            return result;
        }

        public bool Delete(string deleteWord)
        {
            bool found = false;
            int i = 0;

            while (i < wordsList.Count)
            {  
                string word = (string)wordsList[i];
                if (word.ToLower() == deleteWord.ToLower())
                {
                    wordsList.RemoveAt(i);
                    pagesList.RemoveAt(i);
                    found = true;
                }
                else i++;
            }


            return found;
        }
    }
}