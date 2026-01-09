using Mysqlx.Crud;
using System.Xml;

namespace Quiz
{
    public partial class Form1 : Form
    {
        //Diese Klasse ist das Hauptmenü der App und das erste Fenster, das geöffnet wird.

        private Datenbank db;

        private List<Player> liPl = new List<Player>();

        public Form1()
        {
            InitializeComponent();

            db = new Datenbank();

            dispPlayer();
        }

        //Views

        private void dispPlayer() //Füllt die Combobox mit den verfügbaren Spielern.
        {
            liPl = db.getPlayer();
            cbPl.Items.Clear();

            foreach (Player pl in liPl)
            {
                cbPl.Items.Add(pl.Name1);
            }
        }

        public void refreshPlayer() //Aktualisiert die angezeigten Spieler nach Änderungen im Scores-Fenster.
        {
            cbPl.Text = "";
            liPl = db.getPlayer();
            cbPl.Items.Clear();
            foreach (var pl in liPl)
            {
                cbPl.Items.Add(pl.Name1);
            }
        }

        //Buttons

        private void btSt_Click(object sender, EventArgs e) //Button prüft die Auswahl des Spielers, speichert und übergibt diese an Game-Window.
        {
            bool SelClue = rbSHa.Checked || rbSFl.Checked || rbSLa.Checked;
            bool SelGuess = rbFHa.Checked || rbFFl.Checked || rbFLa.Checked;

            if (cbPl.SelectedIndex == -1)
            {
                MessageBox.Show("Such dir einen Spieler aus!");
                return;
            }

            if (!SelClue && !SelGuess)
            {
                MessageBox.Show("Wähle Hinweis und Ziel!");
                return;
            }

            if (!SelClue)
            {
                MessageBox.Show("Welcher Hinweis soll's sein?");
                return;
            }

            if (!SelGuess)
            {
                MessageBox.Show("Was willst du erraten?");
                return;
            }

            if (rbSHa.Checked && rbFHa.Checked ||
                rbSFl.Checked && rbFFl.Checked ||
                rbSLa.Checked && rbFLa.Checked)
            {
                MessageBox.Show("Hey, willst du etwa schummeln? Nix da, versuch’s nochmal!");
                return;
            }

            string cluetype = "";

            //Clue wird aus dem markierten RadioButton der gbS GroupBox in einer Variable gespeichert.

            foreach (RadioButton rb in gbS.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    cluetype = rb.Text;
                    break;
                }
            }

            string guesstype = "";

            //Guess wird aus dem markierten RadioButton der gbF GroupBox in einer Variable gespeichert.

            foreach (RadioButton rb in gbF.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    guesstype = rb.Text;
                    break;
                }
            }

            //User wird in einer Variable gespeichert.

            int userID = liPl[cbPl.SelectedIndex].pID1;

            //Fenster wird erstellt, Informationen werden über einen benutzerdefinierten Konstruktor übergeben.

            GameW form3 = new GameW(this, cluetype, guesstype, userID);
            form3.Show();
            this.Hide();
        }

        private void btPl_Click(object sender, EventArgs e) //Button speichert einen neuen Spieler aus der Eingabe des Benutzers.
        {
            if (tbPl.Text != "")
            {
                Player pl = new Player(0, tbPl.Text);
                db.savePlayer(pl);
                dispPlayer();
                tbPl.Text = "";
            }
        }

        private void btSc_Click(object sender, EventArgs e) //Öffnet Scores und übergibt Form1 über Konstruktor
        {
            Scores form2 = new Scores(this);
            form2.Show();
            this.Hide();
        }
    }
}
