
namespace Lab3_1
{
    partial class Form1
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
            this.btnView = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.lstSlownik = new System.Windows.Forms.ListBox();
            this.lstHistoria = new System.Windows.Forms.ListBox();
            this.rbtnAngielskiPolski = new System.Windows.Forms.RadioButton();
            this.rbtnPolskiAngielski = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtPolskie = new System.Windows.Forms.TextBox();
            this.txtAngielskie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lab3";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnView.Location = new System.Drawing.Point(10, 192);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(207, 43);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "Wyświetl słówka";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(353, 256);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(182, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Dodaj słówko";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDel.Location = new System.Drawing.Point(353, 294);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(182, 34);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Usuń słówko";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click_1);
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHistory.Location = new System.Drawing.Point(690, 192);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(220, 43);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Text = "Historia gry";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click_1);
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTest.Location = new System.Drawing.Point(353, 356);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(182, 75);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Test!";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click_1);
            // 
            // lstSlownik
            // 
            this.lstSlownik.FormattingEnabled = true;
            this.lstSlownik.Location = new System.Drawing.Point(10, 241);
            this.lstSlownik.Name = "lstSlownik";
            this.lstSlownik.Size = new System.Drawing.Size(207, 251);
            this.lstSlownik.TabIndex = 6;
            this.lstSlownik.SelectedIndexChanged += new System.EventHandler(this.lstSlownik_SelectedIndexChanged);
            // 
            // lstHistoria
            // 
            this.lstHistoria.FormattingEnabled = true;
            this.lstHistoria.Location = new System.Drawing.Point(690, 241);
            this.lstHistoria.Name = "lstHistoria";
            this.lstHistoria.Size = new System.Drawing.Size(220, 251);
            this.lstHistoria.TabIndex = 7;
            this.lstHistoria.SelectedIndexChanged += new System.EventHandler(this.lstHistoria_SelectedIndexChanged);
            // 
            // rbtnAngielskiPolski
            // 
            this.rbtnAngielskiPolski.AutoSize = true;
            this.rbtnAngielskiPolski.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnAngielskiPolski.Location = new System.Drawing.Point(41, 94);
            this.rbtnAngielskiPolski.Name = "rbtnAngielskiPolski";
            this.rbtnAngielskiPolski.Size = new System.Drawing.Size(181, 29);
            this.rbtnAngielskiPolski.TabIndex = 8;
            this.rbtnAngielskiPolski.TabStop = true;
            this.rbtnAngielskiPolski.Text = "Angielski/Polski";
            this.rbtnAngielskiPolski.UseVisualStyleBackColor = true;
            // 
            // rbtnPolskiAngielski
            // 
            this.rbtnPolskiAngielski.AutoSize = true;
            this.rbtnPolskiAngielski.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnPolskiAngielski.Location = new System.Drawing.Point(41, 129);
            this.rbtnPolskiAngielski.Name = "rbtnPolskiAngielski";
            this.rbtnPolskiAngielski.Size = new System.Drawing.Size(181, 29);
            this.rbtnPolskiAngielski.TabIndex = 9;
            this.rbtnPolskiAngielski.TabStop = true;
            this.rbtnPolskiAngielski.Text = "Polski/Angielski";
            this.rbtnPolskiAngielski.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatus.Location = new System.Drawing.Point(237, 456);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(98, 24);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Komunikat";
            // 
            // txtPolskie
            // 
            this.txtPolskie.Location = new System.Drawing.Point(353, 206);
            this.txtPolskie.Name = "txtPolskie";
            this.txtPolskie.Size = new System.Drawing.Size(182, 20);
            this.txtPolskie.TabIndex = 11;
            // 
            // txtAngielskie
            // 
            this.txtAngielskie.Location = new System.Drawing.Point(353, 147);
            this.txtAngielskie.Name = "txtAngielskie";
            this.txtAngielskie.Size = new System.Drawing.Size(182, 20);
            this.txtAngielskie.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(367, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Słówko Polskie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(349, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Słówko Angielskie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(376, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Wybierz co ma wyświetlić się jako pierwsze:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(347, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 33);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kreator słówek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 506);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAngielskie);
            this.Controls.Add(this.txtPolskie);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.rbtnPolskiAngielski);
            this.Controls.Add(this.rbtnAngielskiPolski);
            this.Controls.Add(this.lstHistoria);
            this.Controls.Add(this.lstSlownik);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "OlszewskaPaskudzki";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ListBox lstSlownik;
        private System.Windows.Forms.ListBox lstHistoria;
        private System.Windows.Forms.RadioButton rbtnAngielskiPolski;
        private System.Windows.Forms.RadioButton rbtnPolskiAngielski;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtPolskie;
        private System.Windows.Forms.TextBox txtAngielskie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

