using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;


namespace projekt___angielski_quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void tlumacz_Click(object sender, EventArgs e)
        {
            tlumaczenie.Text = "";
            tlumaczenie.ForeColor = Color.Black;
            string word = dotlumaczenia.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(word))
            {
                tlumaczenie.Text = "Wpisz słowo!";
                tlumaczenie.ForeColor = Color.Red;
                return;
            }

            string filePath = "slownik.csv";

            if (!System.IO.File.Exists(filePath))
            {
                tlumaczenie.Text = "Brak pliku ze słownikiem! Przepraszamy!";
                tlumaczenie.ForeColor = Color.Red;
                return;
            }

            string[] wiersze = System.IO.File.ReadAllLines(filePath);

            string translation = null;
            foreach (string wiersz in wiersze)
            {
                if (string.IsNullOrWhiteSpace(wiersz))
                    continue;

                string[] slowa = wiersz.Split(':');
                if (slowa.Length == 2)
                {
                    string ang = slowa[0].Trim().ToLower();
                    string pl = slowa[1].Trim();

                    if (ang == word)
                    {
                        translation = pl;
                        break;
                    }
                }
            } 

            if (translation != null)
            {
                tlumaczenie.Text = translation;
                tlumaczenie.ForeColor = Color.Black;
            }
            else
            {
                tlumaczenie.Text = "Brak słowa w słowniku";
                tlumaczenie.ForeColor = Color.Red;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "INFORMACJE DO TESTU:\n\n"+
                "1. Test zawiera 10 pytań\n"+
                "2. Na każde pytanie masz 10 sekund na odpowiedź\n"+
                "3. Twoim zadaniem będzie przetłumaczenie słowa z języka polskiego na język angielski\n"+
                "4. Za każdą prawidłową odpowiedź otrzymasz 1 punkt\n"+
                "5. Na koniec otrzymasz wynik testu\n\n"+
                "POWODZENIA!"
                
                );

        }
    }
}
