using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace Quiz
{
    public class Datenbank
    {
        //Diese Klasse wird verwendet, um mit Daten aus der Datenbank zu arbeiten.
        //Die get-Methoden erstellen Instanzen der Klassen aus den Tabellendaten und speichern sie in Listen.
        //Die save-Methoden speichern die Informationen in den Tabellen.
        //Die del-Methoden löschen Informationen.

        private MySqlConnection conn;

        public Datenbank()
        {
            string connstr = "SERVER=localhost; UID='root'; PASSWORD=''; DATABASE=quiz;";
            conn = new MySqlConnection(connstr);
        }

        //Game

        public List<Game> getGame()
        {
            List<Game> liGa = new List<Game>();
            MySqlDataReader reader = null;

            try
            {
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
                com.CommandText = "SELECT * FROM Game;";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liGa.Add(
                        new Game(
                            reader.GetInt32(0),
                            reader.IsDBNull(1) ? -1 : reader.GetInt32(1),
                            reader.IsDBNull(2) ? -1 : reader.GetInt32(2)
                            )
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("getGame " + ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    conn.Close();
                }

            }

            return liGa;
        }

        public List<Game> getGameGrid(int whichNo) //Wird verwendet, um das Score-Grid zu füllen.
        {
            List<Game> liGa = new List<Game>();
            MySqlDataReader reader = null;

            try
            {
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
                com.CommandText = string.Format("SELECT * FROM game " +
                                                "WHERE playerID = {0};", whichNo);

                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liGa.Add(
                        new Game(
                            reader.GetInt32(0),
                            reader.IsDBNull(1) ? -1 : reader.GetInt32(1),
                            reader.IsDBNull(2) ? -1 : reader.GetInt32(2)
                            )
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("getGame " + ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    conn.Close();
                }

            }

            return liGa;
        }

        public void saveGame(Game ga)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                if (ga.gID1 == 0)
                {
                    cmd.CommandText = string.Format("INSERT INTO game " +
                                                    "VALUES( NULL, '{0}', '{1}');",
                                                    ga.Score1, ga.playerID1);
                }
                else
                {
                    cmd.CommandText = string.Format("UPDATE game " +
                                                    "SET Score = '{0}', playerID = {1}" +
                                                    "WHERE gID = '{2}';",
                                                    ga.Score1, ga.playerID1, ga.gID1);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("saveGame " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void delGame(int whichNo) //Diese löscht tatsächlich die Scores (Games) eines bestimmten Spielers.
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("DELETE FROM game " +
                                                "WHERE playerID = {0};", whichNo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delGame " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        //Player

        public List<Player> getPlayer()
        {
            List<Player> liPl = new List<Player>();
            MySqlDataReader reader = null;

            try
            {
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
                com.CommandText = "SELECT * FROM player;";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liPl.Add(
                        new Player(
                            reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1)
                            )
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("getPlayer " + ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    conn.Close();
                }

            }

            return liPl;
        }

        public void savePlayer(Player pl)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "INSERT INTO player (Name) VALUES (@name)";
                cmd.Parameters.AddWithValue("@name", pl.Name1);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("savePlayer " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void delPlayer(int whichNo)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("DELETE FROM player " +
                                                "WHERE pID = {0};", whichNo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delPlayer " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        //Capital

        public List<Capital> getCapital()
        {
            List<Capital> liCa = new List<Capital>();
            MySqlDataReader reader = null;

            try
            {
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
                com.CommandText = "SELECT * FROM capital;";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liCa.Add(
                        new Capital(
                            reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1)
                            )
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("getCapital " + ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    conn.Close();
                }

            }

            return liCa;
        }

        //Continent

        public List<Continent> getContinent()
        {
            List<Continent> liCo = new List<Continent>();
            MySqlDataReader reader = null;

            try
            {
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
                com.CommandText = "SELECT * FROM continent;";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liCo.Add(
                        new Continent(
                            reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1)
                            )
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("getContinent " + ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    conn.Close();
                }

            }

            return liCo;
        }

        //Country

        public List<Country> getCountry()
        {
            List<Country> liCou = new List<Country>();
            MySqlDataReader reader = null;

            try
            {
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
                com.CommandText = "SELECT * FROM country;";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liCou.Add(
                        new Country(
                            reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1),
                            reader.IsDBNull(2) ? -1 : reader.GetInt32(2),
                            reader.IsDBNull(3) ? -1 : reader.GetInt32(3),
                            reader.IsDBNull(4) ? -1 : reader.GetInt32(4)
                            )
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("getCountry " + ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    conn.Close();
                }

            }

            return liCou;
        }

        //Flag

        public List<Flag> getFlag()
        {
            List<Flag> liFl = new List<Flag>();
            MySqlDataReader reader = null;

            try
            {
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
                com.CommandText = "SELECT * FROM flag;";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liFl.Add(
                        new Flag(
                            reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1)
                            )
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("getFlag " + ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    conn.Close();
                }

            }

            return liFl;
        }

    }
}
