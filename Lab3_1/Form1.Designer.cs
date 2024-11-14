
namespace Lab3_1
{
    partial class labelTitle
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelTranslate = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelPolish = new System.Windows.Forms.Label();
            this.labelEnglish = new System.Windows.Forms.Label();
            this.textBoxInputWord = new System.Windows.Forms.TextBox();
            this.textBoxPolish = new System.Windows.Forms.TextBox();
            this.textBoxEnglish = new System.Windows.Forms.TextBox();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonAddWord = new System.Windows.Forms.Button();
            this.buttonRemoveWord = new System.Windows.Forms.Button();
            this.buttonShowHistory = new System.Windows.Forms.Button();
            this.buttonStartTest = new System.Windows.Forms.Button();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.comboBoxTestLanguage = new System.Windows.Forms.ComboBox();
            this.listBoxAllWords = new System.Windows.Forms.ListBox();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program do nauki języka angielskiego";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTranslate
            // 
            this.labelTranslate.AutoSize = true;
            this.labelTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTranslate.Location = new System.Drawing.Point(12, 106);
            this.labelTranslate.Name = "labelTranslate";
            this.labelTranslate.Size = new System.Drawing.Size(275, 20);
            this.labelTranslate.TabIndex = 1;
            this.labelTranslate.Text = "Wpisz słowo do przetłumaczenia:";
            this.labelTranslate.Click += new System.EventHandler(this.labelTranslate_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(585, 99);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(85, 29);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "label2";
            this.labelResult.Click += new System.EventHandler(this.labelResult_Click);
            // 
            // labelPolish
            // 
            this.labelPolish.AutoSize = true;
            this.labelPolish.Location = new System.Drawing.Point(47, 218);
            this.labelPolish.Name = "labelPolish";
            this.labelPolish.Size = new System.Drawing.Size(85, 29);
            this.labelPolish.TabIndex = 3;
            this.labelPolish.Text = "label2";
            this.labelPolish.Click += new System.EventHandler(this.labelPolish_Click);
            // 
            // labelEnglish
            // 
            this.labelEnglish.AutoSize = true;
            this.labelEnglish.Location = new System.Drawing.Point(212, 218);
            this.labelEnglish.Name = "labelEnglish";
            this.labelEnglish.Size = new System.Drawing.Size(85, 29);
            this.labelEnglish.TabIndex = 4;
            this.labelEnglish.Text = "label2";
            this.labelEnglish.Click += new System.EventHandler(this.labelEnglish_Click);
            // 
            // textBoxInputWord
            // 
            this.textBoxInputWord.Location = new System.Drawing.Point(309, 99);
            this.textBoxInputWord.Name = "textBoxInputWord";
            this.textBoxInputWord.Size = new System.Drawing.Size(192, 35);
            this.textBoxInputWord.TabIndex = 5;
            this.textBoxInputWord.TextChanged += new System.EventHandler(this.textBoxInputWord_TextChanged);
            // 
            // textBoxPolish
            // 
            this.textBoxPolish.Location = new System.Drawing.Point(42, 250);
            this.textBoxPolish.Name = "textBoxPolish";
            this.textBoxPolish.Size = new System.Drawing.Size(100, 35);
            this.textBoxPolish.TabIndex = 6;
            this.textBoxPolish.TextChanged += new System.EventHandler(this.textBoxPolish_TextChanged);
            // 
            // textBoxEnglish
            // 
            this.textBoxEnglish.Location = new System.Drawing.Point(207, 250);
            this.textBoxEnglish.Name = "textBoxEnglish";
            this.textBoxEnglish.Size = new System.Drawing.Size(100, 35);
            this.textBoxEnglish.TabIndex = 7;
            this.textBoxEnglish.TextChanged += new System.EventHandler(this.textBoxEnglish_TextChanged);
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTranslate.Location = new System.Drawing.Point(383, 150);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(182, 25);
            this.buttonTranslate.TabIndex = 8;
            this.buttonTranslate.Text = "PRZETŁUMACZ";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowAll.Location = new System.Drawing.Point(22, 529);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(201, 24);
            this.buttonShowAll.TabIndex = 9;
            this.buttonShowAll.Text = "WYŚWIETL LISTĘ SŁÓWEK";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            // 
            // buttonAddWord
            // 
            this.buttonAddWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddWord.Location = new System.Drawing.Point(412, 192);
            this.buttonAddWord.Name = "buttonAddWord";
            this.buttonAddWord.Size = new System.Drawing.Size(126, 23);
            this.buttonAddWord.TabIndex = 10;
            this.buttonAddWord.Text = "DODAJ SŁOWO";
            this.buttonAddWord.UseVisualStyleBackColor = true;
            this.buttonAddWord.Click += new System.EventHandler(this.buttonAddWord_Click);
            // 
            // buttonRemoveWord
            // 
            this.buttonRemoveWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRemoveWord.Location = new System.Drawing.Point(412, 236);
            this.buttonRemoveWord.Name = "buttonRemoveWord";
            this.buttonRemoveWord.Size = new System.Drawing.Size(118, 23);
            this.buttonRemoveWord.TabIndex = 11;
            this.buttonRemoveWord.Text = "USUŃ SŁOWO ";
            this.buttonRemoveWord.UseVisualStyleBackColor = true;
            this.buttonRemoveWord.Click += new System.EventHandler(this.buttonRemoveWord_Click);
            // 
            // buttonShowHistory
            // 
            this.buttonShowHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowHistory.Location = new System.Drawing.Point(289, 530);
            this.buttonShowHistory.Name = "buttonShowHistory";
            this.buttonShowHistory.Size = new System.Drawing.Size(170, 23);
            this.buttonShowHistory.TabIndex = 12;
            this.buttonShowHistory.Text = "WYŚWIETL HISTORIĘ";
            this.buttonShowHistory.UseVisualStyleBackColor = true;
            // 
            // buttonStartTest
            // 
            this.buttonStartTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStartTest.Location = new System.Drawing.Point(774, 495);
            this.buttonStartTest.Name = "buttonStartTest";
            this.buttonStartTest.Size = new System.Drawing.Size(176, 53);
            this.buttonStartTest.TabIndex = 13;
            this.buttonStartTest.Text = "ROZPOCZNIJ TEST";
            this.buttonStartTest.UseVisualStyleBackColor = true;
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Items.AddRange(new object[] {
            "Polski -> Angielski",
            "Angielski -> Polski "});
            this.comboBoxDirection.Location = new System.Drawing.Point(755, 138);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(172, 37);
            this.comboBoxDirection.TabIndex = 14;
            // 
            // comboBoxTestLanguage
            // 
            this.comboBoxTestLanguage.FormattingEnabled = true;
            this.comboBoxTestLanguage.Items.AddRange(new object[] {
            "POLSKI",
            "ANGIELSKI"});
            this.comboBoxTestLanguage.Location = new System.Drawing.Point(784, 192);
            this.comboBoxTestLanguage.Name = "comboBoxTestLanguage";
            this.comboBoxTestLanguage.Size = new System.Drawing.Size(121, 37);
            this.comboBoxTestLanguage.TabIndex = 15;
            // 
            // listBoxAllWords
            // 
            this.listBoxAllWords.FormattingEnabled = true;
            this.listBoxAllWords.ItemHeight = 29;
            this.listBoxAllWords.Location = new System.Drawing.Point(22, 370);
            this.listBoxAllWords.Name = "listBoxAllWords";
            this.listBoxAllWords.Size = new System.Drawing.Size(120, 149);
            this.listBoxAllWords.TabIndex = 16;
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.ItemHeight = 29;
            this.listBoxHistory.Location = new System.Drawing.Point(289, 370);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(120, 149);
            this.listBoxHistory.TabIndex = 17;
            // 
            // labelTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1005, 565);
            this.Controls.Add(this.listBoxHistory);
            this.Controls.Add(this.listBoxAllWords);
            this.Controls.Add(this.comboBoxTestLanguage);
            this.Controls.Add(this.comboBoxDirection);
            this.Controls.Add(this.buttonStartTest);
            this.Controls.Add(this.buttonShowHistory);
            this.Controls.Add(this.buttonRemoveWord);
            this.Controls.Add(this.buttonAddWord);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.buttonTranslate);
            this.Controls.Add(this.textBoxEnglish);
            this.Controls.Add(this.textBoxPolish);
            this.Controls.Add(this.textBoxInputWord);
            this.Controls.Add(this.labelEnglish);
            this.Controls.Add(this.labelPolish);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelTranslate);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "labelTitle";
            this.Text = "Program do nauki języka angielskiego";
            this.Load += new System.EventHandler(this.labelTitle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTranslate;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelPolish;
        private System.Windows.Forms.Label labelEnglish;
        private System.Windows.Forms.TextBox textBoxInputWord;
        private System.Windows.Forms.TextBox textBoxPolish;
        private System.Windows.Forms.TextBox textBoxEnglish;
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button buttonAddWord;
        private System.Windows.Forms.Button buttonRemoveWord;
        private System.Windows.Forms.Button buttonShowHistory;
        private System.Windows.Forms.Button buttonStartTest;
        private System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.ComboBox comboBoxTestLanguage;
        private System.Windows.Forms.ListBox listBoxAllWords;
        private System.Windows.Forms.ListBox listBoxHistory;
    }
}

