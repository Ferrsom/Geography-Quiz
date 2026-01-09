using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton; //Dies wurde definiert, um Mehrdeutigkeiten zu vermeiden.

namespace Quiz
{
  
    public partial class GameW : Form
    {
        //Diese Klasse lädt das aktuelle Spiel-Fenster und steuert dessen Verhalten.

        private Form1 previousForm;
        private string clueType;
        private string guessType;
        private int qnum = 0;
        private int score = 0;
        private int userID;

        private Datenbank db;

        private List<Capital> liCa = new List<Capital>();
        private List<Flag> liFl = new List<Flag>();
        private List<Continent> liCo = new List<Continent>();
        private List<Country> liCou = new List<Country>();
        private List<Question> liQu = new List<Question>();

        private const string pfad = "C:\\Users\\tn\\Desktop\\Quiz\\Assets\\"; //Um die Flaggenbilder zu laden

        public GameW()
        {
            InitializeComponent();

            db = new Datenbank();

            liCa = db.getCapital();
            liFl = db.getFlag();
            liCou = db.getCountry();
            liQu = genQuestion();

        }

        public GameW(Form1 form1, string clueType, string guessType, int userID) : this()  
        {
            //Benutzerdefinierter Constructor
            //Clue, Guess und User werden erhält. Ruft zuerst den Standardkonstruktor auf

            previousForm = form1;
            this.clueType = clueType;
            this.guessType = guessType;
            this.userID = userID;

            showQuestion(); //Die Methode wird aufgerufen, um die Fragen anzuzeigen.
        }

        //Closing

        private void GameW_FormClosing(object sender, FormClosingEventArgs e) //Verhalten beim Schließen des Fensters.
        {
            if (previousForm != null)
            { 
                previousForm.Show();
            }
        }

        private void btnBa_Click(object sender, EventArgs e) //Verhalten beim Schließen des Fensters.
        {
            if (previousForm != null)
            {
                previousForm.Show();
                this.Close();
            }
        }

        //Questions

        /// Die Methoden zur Erstellung der Fragen basieren auf dem "CorrectCountry"
        
        ///Von diesem Land werden die Attribute für den Hinweis und die richtige Antwort genommen
        
        ///Zusätzlich werden drei Attribute anderer zufälliger Länder als falsche Antworten angezeigt

        private List<Question> genQuestion() //Diese Methode erzeugt eine zufällige Fragenliste.
        {
            List<Question> questions = new List<Question>();

            while (questions.Count < 10) //Wir wollen 10 Fragen
            {
                Random rnd = new Random(); //Initialisiert einen Zufallsgenerator

                List<int> rndNums = new List<int>(); //Eine Liste von Zahlen wird erstellt

                for (int j = 0; j < 4; j++)
                {
                    int n = rnd.Next(0, liCou.Count);
                    while (rndNums.Contains(n))
                    {
                        n = rnd.Next(0, liCou.Count); //Wenn vorhanden, neue Zufallszahl erzeugt. Begrenzung ist Länder in der Liste
                    } 
                    
                    rndNums.Add(n); //Wenn die Liste die Zahl noch nicht enthält, wird sie hinzugefügt.
                }

                //Die Zufallszahlen aus der Liste wrrden genutzt, um zufällige Objects von Country-List auszuwählen.
                //So wird garantiert, dass die Ländern nicht nur zufällig sind, sondern dass sich als Optionen nicht wiederholen.

                Country rndC1 = liCou[rndNums[0]];
                Country rndC2 = liCou[rndNums[1]];
                Country rndC3 = liCou[rndNums[2]];
                Country rndC4 = liCou[rndNums[3]];

                //Eine neue Liste wird mit diesen vier erstellt.

                List<Country> listC = new List<Country>();

                listC.Add(rndC1);
                listC.Add(rndC2);
                listC.Add(rndC3);
                listC.Add(rndC4);

                //Wir wählen zufällig eines davon als korrektes aus.

                Country rndCorrectCountry = listC[rnd.Next(0, 4)];

                //Ein neues Question-Object wird erstellt. Erhält eine Liste von 4 zufälligen Ländern, von denen eins korrekt ist

                Question q = new Question(rndCorrectCountry, listC);

                //Damit werden die vier Vermutungen festgelegt, die angezeigt werden.

                //Bevor Speicherung der Frage, sicherstellen dass der als Hinweis gestellte Inhalt sich ebenfalls nicht wiederholt.

                bool exists = false;
                foreach (Question existingQ in questions)
                {
                    if (existingQ.CorrectCountry1.Name1 == q.CorrectCountry1.Name1)
                    {
                        exists = true; //Wenn vorhanden beendet diesen Durchlauf
                        break;
                    }
                }

                if (!exists) 
                {
                    questions.Add(q); //Wenn nicht vorhanden, wird gespeichert.
                }

            }

            return questions;
        }

        private void showQuestion() //Diese Methode lädt die richtigen Informationen aus einer Frage in der Liste.
        {
            Question currentQuestion = liQu[qnum]; //Die Frage wir vom Zähler definiert

            //Ein Switch wird verwendet, um den richtigen Hinweis entsprechend der Auswahl des Benutzers zu laden.

            switch (clueType) //Vom Form1 bekommen
            {
                case "Hauptstädten":
                    lblCl.Text = findCapital(currentQuestion.CorrectCountry1);
                    break;

                case "Flaggen":
                    int fn = currentQuestion.CorrectCountry1.flagID1;
                    lblCl.Hide();
                    string bild = pfad + fn.ToString() + ".gif"; //Flaggen sind vom Developer gennant und gespeichert
                    
                    if (File.Exists(bild)) //Added to handle exception
                    {
                        pbFl.Image = Image.FromFile(bild);
                    }
                    else
                    {
                        pbFl.Image = null;
                    }

                    break;

                case "Ländern":
                    lblCl.Text = currentQuestion.CorrectCountry1.Name1;
                    break;
            }

            //Ein Switch wird verwendet, um die richtigen Vermutungen entsprechend der Auswahl des Benutzers zu laden.
            //4 mögliche Antworten. Informationen werden aus der PossibleCountries übernommen, eines davon ist auch das richtige.

            switch (guessType) //Vom Form1 bekommen
            {
                case "Hauptstädten":
                    rb1.Text = findCapital(currentQuestion.PossibleCountries1[0]);
                    rb2.Text = findCapital(currentQuestion.PossibleCountries1[1]);
                    rb3.Text = findCapital(currentQuestion.PossibleCountries1[2]);
                    rb4.Text = findCapital(currentQuestion.PossibleCountries1[3]);
                    break;

                case "Flaggen":
                    rb1.Text = "";
                    rb2.Text = "";
                    rb3.Text = "";
                    rb4.Text = "";

                    string b1 = pfad + currentQuestion.PossibleCountries1[0].flagID1.ToString() + ".gif";
                    string b2 = pfad + currentQuestion.PossibleCountries1[1].flagID1.ToString() + ".gif";
                    string b3 = pfad + currentQuestion.PossibleCountries1[2].flagID1.ToString() + ".gif";
                    string b4 = pfad + currentQuestion.PossibleCountries1[3].flagID1.ToString() + ".gif";

                    if (File.Exists(b1))
                        rb1.Image = Image.FromFile(b1);
                    else
                        rb1.Image = null;

                    if (File.Exists(b2))
                        rb2.Image = Image.FromFile(b2);
                    else
                        rb2.Image = null;

                    if (File.Exists(b3))
                        rb3.Image = Image.FromFile(b3);
                    else
                        rb3.Image = null;

                    if (File.Exists(b4))
                        rb4.Image = Image.FromFile(b4);
                    else
                        rb4.Image = null;

                    break;

                case "Ländern":
                    rb1.Text = currentQuestion.PossibleCountries1[0].Name1;
                    rb2.Text = currentQuestion.PossibleCountries1[1].Name1;
                    rb3.Text = currentQuestion.PossibleCountries1[2].Name1;
                    rb4.Text = currentQuestion.PossibleCountries1[3].Name1;
                    break;
            }

            //Am Ende werden die RadioButtons (Antworten) mit dem Namen des jeweiligen Landes getaggt
            //Um die Korrektheit der Antwort zu überprüfen.

            rb1.Tag = currentQuestion.PossibleCountries1[0].Name1;
            rb2.Tag = currentQuestion.PossibleCountries1[1].Name1;
            rb3.Tag = currentQuestion.PossibleCountries1[2].Name1;
            rb4.Tag = currentQuestion.PossibleCountries1[3].Name1;

        }

        private string findCapital(Country cou) //Methode mit Lambda, die den Namen einer Hauptstadt über die Länder-ID ermittelt
        {
            return liCa.Find(x => x.caID1 == cou.capitalID1).Name1;
        }

        //Buttons

        private void btnAn_Click(object sender, EventArgs e) //Überprüft Antwort, gibt Feedback und steuert den Verlauf des Spiels.
        {
            Question currentQuestion = liQu[qnum];

            foreach (RadioButton rb in this.Controls.OfType<RadioButton>()) //Dies überprüft alle RadioButtons im Form
            {
                if (rb.Checked)
                {
                    if (rb.Tag == currentQuestion.CorrectCountry1.Name1) //Übereinstimmung vom Tag (Country, von dem das Attribut kommt) mit CorrectCountry
                    {
                        MessageBox.Show("Richtig!");
                        score += 100;
                    }
                    else
                    {
                        MessageBox.Show("Falsch :(");
                    }
                }
            }

            qnum += 1; //Zähler aktualisiert

            if (qnum == 10) //Das Spiel endet nach 10 Fragen
            {
                MessageBox.Show("Fertig! Dein Score is " + score);
                Game ga = new Game(0,score,userID); //Game-Objekt wird erzeugt mit Score und zugehörigen Spieler
                db.saveGame(ga); //Das Objekt wird verwendet, um die Informationen in der Datenbank zu speichern
                previousForm.Show();
                this.Close();
                return;
            }

            showQuestion(); //Zeigt eine neue Frage wenn Spiel noch nicht beendet ist
        }
    }
}
