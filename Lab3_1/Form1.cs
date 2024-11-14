using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Lab3_1
{
    public partial class Form1 : Form
    {
       
        private Dictionary<string, string> słownik = new Dictionary<string, string> //sł pl ang
        {
            {"kot", "cat"},
            {"pies", "dog"},
            {"dom", "house"},
            {"szkoła", "school"},
            {"książka", "book"},
            {"samochód", "car"},
            {"stół", "table"},
            {"krzesło", "chair"},
            {"człowiek", "human"},
            {"słońce", "sun"},
            {"księżyc", "moon"},
            {"jabłko", "apple"},
            {"dziecko", "child"},
            {"mama", "mom"},
            {"tata", "dad"}
        };

        private List<string> historiaTłumaczeń = new List<string>();
        private HashSet<string> przetestowaneSłówka = new HashSet<string>();

        public Form1()
        {
            InitializeComponent();
        }

        
      

        
        private void BtnView_Click(object sender, EventArgs e) //słownik
        {
            lstSlownik.Items.Clear();
            bool poPolskuNaAngielski = rbtnPolskiAngielski.Checked;

            var posortowanySłownik = poPolskuNaAngielski
                ? słownik.OrderBy(x => x.Key)
                : słownik.OrderBy(x => x.Value);

            foreach (var para in posortowanySłownik)
            {
                if (poPolskuNaAngielski)
                    lstSlownik.Items.Add($"{para.Key} - {para.Value}");
                else
                    lstSlownik.Items.Add($"{para.Value} - {para.Key}");
            }
        }

     

        ///

        private void RbtnAngielskiPolski_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbtnPolskiAngielski_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            lstSlownik.Items.Clear();
            bool poPolskuNaAngielski = rbtnPolskiAngielski.Checked;

            var posortowanySłownik = poPolskuNaAngielski
                ? słownik.OrderBy(x => x.Key)
                : słownik.OrderBy(x => x.Value);

            foreach (var para in posortowanySłownik)
            {
                if (poPolskuNaAngielski)
                    lstSlownik.Items.Add($"{para.Key} - {para.Value}");
                else
                    lstSlownik.Items.Add($"{para.Value} - {para.Key}");
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string polskie = txtPolskie.Text.ToLower();
            string angielskie = txtAngielskie.Text.ToLower();

            if (string.IsNullOrEmpty(polskie) || string.IsNullOrEmpty(angielskie))
            {
              //  lblStatus.Text = "Proszę wprowadzić oba słówka.";
                MessageBox.Show("Proszę wprowadzić oba słówka!");
                return;
            }

            if (!słownik.ContainsKey(polskie))
            {
                słownik.Add(polskie, angielskie);
                // lblStatus.Text = "Słówko dodane!";
                MessageBox.Show("Słówko dodane!");
            }
            else
            {
                // lblStatus.Text = "To słowko już istnieje!";
                MessageBox.Show("To słowko już istnieje!");
            }
        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            string polskie = txtPolskie.Text.ToLower();

            if (string.IsNullOrEmpty(polskie))
            {
             //   lblStatus.Text = "Proszę wprowadzić słówko do usunięcia.";
                MessageBox.Show("Proszę wprowadzić słówko do usunięcia");
                return;
            }

            if (słownik.Remove(polskie))
            {
             //   lblStatus.Text = "Słówko usunięte!";
                MessageBox.Show("Słówko usunięte!");
            }
            else
            {
              //  lblStatus.Text = "Słówko nie znaleziono!";
                MessageBox.Show("Słówko nie znaleziono!");
            }
        }

        private void btnHistory_Click_1(object sender, EventArgs e)
        {
            lstHistoria.Items.Clear();
            foreach (var tłumaczenie in historiaTłumaczeń)
            {
                lstHistoria.Items.Add(tłumaczenie);
            }
        }

        private void btnTest_Click_1(object sender, EventArgs e)
        {
            Random los = new Random();
            przetestowaneSłówka.Clear();
            bool testPoPolsku = rbtnPolskiAngielski.Checked;

            while (przetestowaneSłówka.Count < słownik.Count)
            {
                var para = słownik.ElementAt(los.Next(słownik.Count));

                if (!przetestowaneSłówka.Contains(para.Key))
                {
                    przetestowaneSłówka.Add(para.Key);
                    string pytanie = testPoPolsku ? para.Key : para.Value;
                    string odpowiedź = testPoPolsku ? para.Value : para.Key;

                    string userAnswer = Microsoft.VisualBasic.Interaction.InputBox($"Przetłumacz: {pytanie}", "Test słówek");
                    if (userAnswer.ToLower() == odpowiedź.ToLower())
                    {
                        historiaTłumaczeń.Add($"Poprawnie: {pytanie} -> {odpowiedź}");
                    }
                    else
                    {
                        historiaTłumaczeń.Add($"Błąd: {pytanie} -> {odpowiedź} (Twoja odpowiedź: {userAnswer})");
                    }
                }
            }
            MessageBox.Show("Test zakończony!");
        }

        //niepotrzebne dodane przypadkiem
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstSlownik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstHistoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}