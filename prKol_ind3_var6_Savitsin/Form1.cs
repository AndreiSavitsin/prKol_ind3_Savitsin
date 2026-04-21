using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;

namespace prKol_ind3_var6_Savitsin
{
    public partial class Form1 : Form
    {
        private Index index = new Index();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddWord_Click(object sender, EventArgs e) //Кнопка добавить
        {
            string word = txtWord.Text.Trim();
            string pageStr = txtPage.Text.Trim();

            if (word == "")
            {
                MessageBox.Show("Введите слово!");
                return;
            }

            if (pageStr == "")
            {
                MessageBox.Show("Введите номер страницы!");
                return;
            }

            int page;
            if (!int.TryParse(pageStr, out page))
            {
                MessageBox.Show("Номер страницы должен быть числом!");
                return;
            }

            if (page <= 0)
            {
                MessageBox.Show("Номер страницы должен быть больше 0!");
                return;
            }

            index.Add(word, page);
            txtResult.Text = index.ShowAll();
            txtWord.Clear();
            txtPage.Clear();
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e) //Кнопка загрузить из файла
        {
            index.LoadFromFile();
            txtResult.Text = index.ShowAll();
            MessageBox.Show("Файл загружен!");
        }

        private void btnShow_Click(object sender, EventArgs e) //Кнопка показать
        {
            txtResult.Text = index.ShowAll();
        }

        private void btnSearchWord_Click(object sender, EventArgs e) //Кнопка найти слово
        {
            string word = txtWord.Text.Trim();

            if (word == "")
            {
                MessageBox.Show("Введите слово для поиска!");
                return;
            }

            txtResult.Text = index.Find(word);
        }

        private void btnDelete_Click(object sender, EventArgs e) //Кнопка удалить
        {
            string word = txtWord.Text.Trim();

            if (word == "")
            {
                MessageBox.Show("Введите слово для удаления!");
                return;
            }

            if (index.Delete(word))
            {
                txtResult.Text = index.ShowAll();
                MessageBox.Show("Удалено!");
            }
            else
            {
                MessageBox.Show("Слово не найдено!");
            }
        }
    }
}
