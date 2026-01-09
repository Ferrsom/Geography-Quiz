using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Scores : Form
    {
        //Diese Klasse steuert das Verhalten des Scores-Fensters.

        private Form1 previousForm;

        private Datenbank db;

        private List<Game> liGa = new List<Game>();
        private List<Player> liPl = new List<Player>();
        
        public Scores()
        {
            InitializeComponent();

            db = new Datenbank();

            dispPlayer();
            fillGrid();
        }

        public Scores(Form1 form1) : this() //Dies ruft zuerst den Standardkonstruktor auf.
        {
            previousForm = form1; //Empfängt das vorherige Fenster als Information.
        }

        //Closing

        private void Scores_FormClosing(object sender, FormClosingEventArgs e) //Verhalten beim Schließen des Fensters.
        {
            if (previousForm != null)
            {
                previousForm.refreshPlayer();
            }
            previousForm.Show();
        }

        private void btBa_Click(object sender, EventArgs e) //Verhalten beim Schließen des Fensters.
        {
            if (previousForm != null)
            {
                previousForm.refreshPlayer();
                previousForm.Show();
                this.Close();
            }
        }

        //Views

        private void fillGrid() //Füllt GridView mit den gespeicherten Scores und den zugehörigen Spielern.
        {
            dgvSc.Rows.Clear();

            liGa = db.getGame();
            liPl = db.getPlayer();

            foreach (Game ga in liGa)
            {
                string pl = liPl.Find(x => x.pID1 == ga.playerID1) == null ? "" :
                            liPl.Find(x => x.pID1 == ga.playerID1).Name1;

                dgvSc.Rows.Add(pl, ga.Score1);
            }
        }

        private void dispPlayer()  ////Füllt die Combobox mit den verfügbaren Spielern
        {
            liPl = db.getPlayer();
            cbSc.Items.Clear();

            foreach (Player pl in liPl)
            {
                cbSc.Items.Add(pl.Name1);
            }
        }

        //Buttons

        private void cbSc_SelectedIndexChanged(object sender, EventArgs e) //Zeigt im Grid die Scores einem bestimmten Spieler an.
        {
            if (cbSc.SelectedIndex < 0)
                return; //Wird verwendet, um Fehler nach dem Löschen eines Spielers zu vermeiden

            dgvSc.Rows.Clear();

            int n = liPl[cbSc.SelectedIndex].pID1;

            liGa = db.getGameGrid(n);
            liPl = db.getPlayer();

            foreach (Game ga in liGa)
            {
                string pl = liPl.Find(x => x.pID1 == ga.playerID1) == null ? "" :
                            liPl.Find(x => x.pID1 == ga.playerID1).Name1;

                dgvSc.Rows.Add(pl, ga.Score1);
            }
        }

        private void btnCl_Click(object sender, EventArgs e) //Leert die Combobox, um alle Players im Grid neu zu laden.
        {
            cbSc.SelectedIndex = -1;
            dgvSc.Rows.Clear();
            fillGrid();
        }

        private void btnDe_Click(object sender, EventArgs e) //Löscht einen Spieler und alle seine Scores (Games)
        {
            //Wegen der Fremdschlüssel müssen die Einträge in "Game" vor dem Player gelöscht werden.

            if (cbSc.SelectedIndex != -1)
            {
                int n = liPl[cbSc.SelectedIndex].pID1;
                db.delGame(n);
                db.delPlayer(n);
                dispPlayer();
                fillGrid();
                cbSc.SelectedIndex = -1;
                cbSc.Text = "";
            }
        }
    }
}
