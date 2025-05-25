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
using System.IO;


namespace projekt___angielski_quiz
{
    public partial class Form1 : Form
    {
        private List<(string ang, string pl)> slowka = new List<(string, string)>();
        private int currentIndex = -1;
        private int correctCount = 0;
        private int wrongCount = 0;
        private Timer quizTimer = new Timer();
        private int remainingTime;
        private bool isQuizActive = false;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            quizTimer.Interval = 1000;
            quizTimer.Tick += QuizTimer_Tick;
            odpowiedz.KeyDown += Odpowiedz_KeyDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Możesz dodać coś przy starcie, jeśli chcesz
        }

        private void start_Click(object sender, EventArgs e)
        {
            StartQuiz();
        }

        private void StartQuiz()
        {
            wynikPictureBox.Visible = false;
            string filePath = "slownik.csv";
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Brak pliku slownik.csv");
                return;
            }

            slowka.Clear();
            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split(':');
                if (parts.Length == 2)
                {
                    slowka.Add((parts[0].Trim().ToLower(), parts[1].Trim().ToLower()));
                }
            }

            if (slowka.Count == 0)
            {
                MessageBox.Show("Brak słówek w pliku!");
                return;
            }

            Shuffle(slowka);
            slowka = slowka.Take(10).ToList();

            currentIndex = -1;
            correctCount = 0;
            wrongCount = 0;
            prawidlowe.Text = "0";
            bledne.Text = "0";
            isQuizActive = true;
            ShowNextQuestion();
        }

        private void Shuffle(List<(string ang, string pl)> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                int k = random.Next(n--);
                (list[n], list[k]) = (list[k], list[n]);
            }
        }

        private void ShowNextQuestion()
        {
            currentIndex++;
            if (currentIndex >= slowka.Count)
            {
                EndQuiz();
                return;
            }

            losowe.Text = slowka[currentIndex].pl;
            odpowiedz.Text = "";
            odpowiedz.Focus();
            remainingTime = 10;
            timelabel.Text = "10";
            quizTimer.Start();
        }

        private void QuizTimer_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            timelabel.Text = remainingTime.ToString();

            if (remainingTime <= 0)
            {
                quizTimer.Stop();
                HandleAnswer(null); // brak odpowiedzi = błąd
                ShowNextQuestion();
            }
        }

        private void Odpowiedz_KeyDown(object sender, KeyEventArgs e)
        {
            if (isQuizActive && e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                quizTimer.Stop();
                HandleAnswer(odpowiedz.Text.Trim());
                ShowNextQuestion();
            }
        }

        private void HandleAnswer(string userInput)
        {
            string correctAnswer = slowka[currentIndex].ang;

            if (string.IsNullOrWhiteSpace(userInput))
            {
                wrongCount++;
                bledne.Text = wrongCount.ToString();
                MessageBox.Show($"Czas minął! Poprawna odpowiedź to: {correctAnswer}");
            }
            else if (string.Equals(userInput, correctAnswer, StringComparison.InvariantCultureIgnoreCase))
            {
                correctCount++;
                prawidlowe.Text = correctCount.ToString();
                MessageBox.Show("Poprawna odpowiedź!");
            }
            else
            {
                wrongCount++;
                bledne.Text = wrongCount.ToString();
                MessageBox.Show($"Niepoprawnie! Poprawna odpowiedź to: {correctAnswer}");
            }
        }

        private void EndQuiz()
        {
            isQuizActive = false;
            quizTimer.Stop();
            MessageBox.Show($"Koniec quizu!\nPoprawne: {correctCount}\nBłędne: {wrongCount}");
            losowe.Text = "";
            odpowiedz.Text = "";
            if (correctCount >= 6)
            {
                try
                {
                    wynikPictureBox.Image = Properties.Resources.zdane_jpeg;
                    wynikPictureBox.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nie znaleziono pliku obrazka zdane.jpeg: " + ex.Message);
                }
            }
            else
            {
                wynikPictureBox.Image = Properties.Resources.niezdane1;
                wynikPictureBox.Visible = true;
            }
        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "INFORMACJE DO TESTU:\n\n" +
                "1. Test zawiera 10 pytań\n" +
                "2. Na każde pytanie masz 10 sekund na odpowiedź\n" +
                "3. Twoim zadaniem jest przetłumaczenie słowa z języka polskiego na angielski\n" +
                "4. Aby Twoja odpowiedź została zatwierdzona klinknij pzrycisk ENTER\n" +
                "5. Za każdą prawidłową odpowiedź otrzymujesz 1 punkt\n" +
                "6. Na koniec poznasz swój wynik\n\n" +
                "POWODZENIA!"
            );
        }


        private void tlumacz_Click(object sender, EventArgs e)
        {
            tlumaczenie.Text = "";
            tlumaczenie.ForeColor = System.Drawing.Color.Black;
            string word = dotlumaczenia.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(word))
            {
                tlumaczenie.Text = "Wpisz słowo!";
                tlumaczenie.ForeColor = System.Drawing.Color.Red;
                return;
            }

            string filePath = "slownik.csv";
            if (!File.Exists(filePath))
            {
                tlumaczenie.Text = "Brak pliku ze słownikiem!";
                tlumaczenie.ForeColor = System.Drawing.Color.Red;
                return;
            }

            string[] wiersze = File.ReadAllLines(filePath);
            string translation = null;

            foreach (string wiersz in wiersze)
            {
                if (string.IsNullOrWhiteSpace(wiersz))
                    continue;

                string[] slowa = wiersz.Split(':');
                if (slowa.Length == 2)
                {
                    string ang = slowa[0].Trim().ToLower();
                    string pl = slowa[1].Trim().ToLower();

                    if (ang == word)
                    {
                        translation = pl;
                        break;
                    }
                    else if (pl == word)
                    {
                        translation = ang;
                        break;
                    }
                }
            }

            if (translation != null)
            {
                tlumaczenie.Text = translation;
                tlumaczenie.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                tlumaczenie.Text = "Brak słowa w słowniku";
                tlumaczenie.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) { }


    }
}