using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Project_Bluebird
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Globaal.Connection.Open();
        }

        private void LoadItems()
        {
            Listbox.Items.Clear();
            Cbox.Items.Clear();

            OleDbDataReader dbread = null;
            OleDbConnection con = new OleDbConnection();

            string sql = "SELECT Stoelnaam, Stoelnr, Passagierid, Naam FROM (( Stoel" +
                " LEFT JOIN Reservering" +
                " ON Stoel.Stoelnr = Reservering.Stoelid)" +
                " LEFT JOIN Passagier" +
                " ON Reservering.Passagierid = Passagier.Passagiernr)";

            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);

            dbread = dbcom.ExecuteReader();

            while (dbread.Read())
            {
                string stoelnaam = dbread.GetString(0);
                int stoelId = dbread.GetInt32(1);
                string passagierNaam = "vrij";

                if (!dbread.IsDBNull(2))
                {
                    passagierNaam = dbread.GetString(3);
                }
                ;

                Listbox.Items.Add(stoelnaam + " " + passagierNaam);
                Cbox.Items.Add(stoelnaam);

            }

            dbcom.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void LBstoelenLijst_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbDataReader dbread = null;
            OleDbConnection con = new OleDbConnection();
            string sql = "SELECT Stoelnaam FROM Stoel";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            dbread = dbcom.ExecuteReader();

            string woord = "";
            int selectedIndex = Listbox.SelectedIndex;

            if (selectedIndex >= 0)
            {
                if (dbread.HasRows)
                {
                    int rowIndex = 0;
                    while (rowIndex <= selectedIndex && dbread.Read())
                    {
                        if (rowIndex == selectedIndex)
                        {
                            woord = dbread.GetString(0);
                            break;
                        }
                        rowIndex++;
                    }
                }
            }

            OleDbDataReader dbread2 = null;
            OleDbConnection con2 = new OleDbConnection();
            string sql2 = "SELECT naam FROM Passagier";
            OleDbCommand dbcom2 = new OleDbCommand(sql2, Globaal.Connection);
            dbread2 = dbcom2.ExecuteReader();

            string naam = "";
            int selectedIndex2 = Listbox.SelectedIndex;

            if (selectedIndex2 >= 0)
            {
                if (dbread2.HasRows)
                {
                    int rowIndex2 = 0;
                    while (rowIndex2 <= selectedIndex2 && dbread2.Read())
                    {
                        if (rowIndex2 == selectedIndex2)
                        {
                            naam = dbread2.GetString(0);
                            break;
                        }
                        rowIndex2++;
                    }
                }
            }
            Cbox.Text = woord;
            txtNaam.Text = naam;
        }

        private void BTprogrammaAfsluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RBClass_CheckedChanged(object sender, EventArgs e)
        {
            Cbox.Text = null;

            if (Radiofirst.Checked)
            {
                string[] firstClass = { "1A", "1B", "1C", "1D" };
                Cbox.Items.Clear();
                Cbox.Items.AddRange(firstClass);
            }
            else if (Radiobusiness.Checked)
            {
                string[] businessClass = { "2A", "2B", "2C", "2D", "3A", "3B", "3C", "3D" };
                Cbox.Items.Clear();
                Cbox.Items.AddRange(businessClass);
            }
            else if (Radioeconomy.Checked)
            {
                string[] economyClass = { "4A", "4B", "4C", "4D", "5A", "5B", "5C", "5D" };
                Cbox.Items.Clear();
                Cbox.Items.AddRange(economyClass);
            }
        }
        private void BTstoelToevoegen_Click(object sender, EventArgs e)
        {
            try
            {
                string naam = txtNaam.Text;
                string stoel = Cbox.Text;

                if (naam != "" || stoel != "")
                {
                    string sql1 = "INSERT INTO Passagier (Naam) VALUES (@Naam)";
                    OleDbCommand dbcom1 = new OleDbCommand(sql1, Globaal.Connection);
                    dbcom1.Parameters.AddWithValue("@Naam", naam);
                    dbcom1.ExecuteNonQuery();

                    string sql2 = "SELECT MAX(Passagiernr) FROM Passagier";
                    OleDbCommand dbcom2 = new OleDbCommand(sql2, Globaal.Connection);
                    int passagierId = (int)dbcom2.ExecuteScalar();

                    string sql3 = "SELECT Stoelnr FROM Stoel WHERE Stoelnaam = @Stoelnaam";
                    OleDbCommand dbcom3 = new OleDbCommand(sql3, Globaal.Connection);
                    dbcom3.Parameters.AddWithValue("@Stoelnaam", stoel);
                    int stoelId = (int)dbcom3.ExecuteScalar();

                    string sql4 = "INSERT INTO Reservering (Passagierid, Stoelid) VALUES (@Passagierid, @Stoelid)";
                    OleDbCommand dbcom4 = new OleDbCommand(sql4, Globaal.Connection);
                    dbcom4.Parameters.AddWithValue("@Passagierid", passagierId);
                    dbcom4.Parameters.AddWithValue("@Stoelid", stoelId);
                    dbcom4.ExecuteNonQuery();

                    dbcom1.Dispose();
                    dbcom2.Dispose();
                    dbcom3.Dispose();
                    dbcom4.Dispose();
                    Listbox.Items.Clear();
                    LoadItems();
                }
                else
                {
                    MessageBox.Show("niet alles ingevuld");
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Naam weergeven");
            }
        }

        private void BTstoelVrijgeven_Click(object sender, EventArgs e)
        {
            try
            {
                string naam = txtNaam.Text;

                string sql1 = "SELECT Passagiernr FROM Passagier WHERE Naam = @Naam";
                OleDbCommand dbcom1 = new OleDbCommand(sql1, Globaal.Connection);
                dbcom1.Parameters.AddWithValue("@Naam", naam);
                int passagierId = (int)dbcom1.ExecuteScalar();

                string sql2 = "DELETE FROM Reservering Where Passagierid = @Passagierid";
                OleDbCommand dbcom2 = new OleDbCommand(sql2, Globaal.Connection);
                dbcom2.Parameters.AddWithValue("@Passagierid", passagierId);
                dbcom2.ExecuteNonQuery();

                string sql3 = "DELETE FROM Passagier WHERE Passagiernr = @Passagiernr";
                OleDbCommand dbcom3 = new OleDbCommand(sql3, Globaal.Connection);
                dbcom3.Parameters.AddWithValue("@Passagiernr", passagierId);
                dbcom3.ExecuteNonQuery();

                dbcom1.Dispose();
                dbcom2.Dispose();
                dbcom3.Dispose();
                txtNaam.Text = "";
                Listbox.Items.Clear();
                LoadItems();
            }
            catch (Exception)
            {
                MessageBox.Show("geen stoel met passagier");
            }
        }
    }
}
