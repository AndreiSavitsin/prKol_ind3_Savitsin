
namespace prKol_ind3_var6_Savitsin
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.btnSearchWord = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(97, 112);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(100, 20);
            this.txtWord.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите слово:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите номер страницы:";
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(238, 112);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(136, 20);
            this.txtPage.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(97, 247);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(402, 171);
            this.txtResult.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результат:";
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(97, 151);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(75, 23);
            this.btnAddWord.TabIndex = 6;
            this.btnAddWord.Text = "Добавить слово";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Location = new System.Drawing.Point(187, 151);
            this.btnLoadFromFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(136, 23);
            this.btnLoadFromFile.TabIndex = 7;
            this.btnLoadFromFile.Text = "Загрузить из файла";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // btnSearchWord
            // 
            this.btnSearchWord.Location = new System.Drawing.Point(435, 151);
            this.btnSearchWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchWord.Name = "btnSearchWord";
            this.btnSearchWord.Size = new System.Drawing.Size(112, 23);
            this.btnSearchWord.TabIndex = 9;
            this.btnSearchWord.Text = "Найти слово";
            this.btnSearchWord.UseVisualStyleBackColor = true;
            this.btnSearchWord.Click += new System.EventHandler(this.btnSearchWord_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(99, 189);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 25);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Удалить слово";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(343, 151);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 43);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Показать всё";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 528);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearchWord);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnLoadFromFile);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.Button btnSearchWord;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShow;
    }
}

