using PICvjecara.DBClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PICvjecara
{
    public partial class frmRacuni : Form
    {        
        private int sifra_racuna = 0;
        private int rezultat;
        private int suma;
        private List<string> listaDatuma;

        public frmRacuni()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void frmRacuni_Load(object sender, EventArgs e)
        {
            listaDatuma = Racuni.DohvatiDisDatum();
            cmbDatum.DataSource = listaDatuma;

            string datum = cmbDatum.SelectedValue.ToString();

            // TODO: This line of code loads data into the '_16027_DBDataSet2.Racuni' table. You can move, or remove it, as needed.
            this.racuniTableAdapter1.FillByDatum(this._16027_DBDataSet2.Racuni, datum);

        }

        private void dgvRacuni_SelectionChanged(object sender, EventArgs e)
        {
            rezultat = 0;

            if (dgvRacuni.SelectedRows.Count > 0)
            {
                sifra_racuna = int.Parse(dgvRacuni.SelectedCells[1].Value.ToString());

                // TODO: This line of code loads data into the '_16027_DBDataSet2.Racuni_tablica' table. You can move, or remove it, as needed.
                this.racuni_tablicaTableAdapter1.FillByStavka(this._16027_DBDataSet2.Racuni_tablica, sifra_racuna);

                for (int i = 0; i < dgvStavkeRacuna.Rows.Count - 1; i++)
                {
                    suma = int.Parse(dgvStavkeRacuna.Rows[i].Cells[3].Value.ToString()) * int.Parse(dgvStavkeRacuna.Rows[i].Cells[4].Value.ToString());
                    rezultat = rezultat + suma;
                }

                lblIznos.Text = rezultat.ToString() + " kn";
            }
        }

        private void cmbDatum_SelectedValueChanged(object sender, EventArgs e)
        {
            string datum = cmbDatum.SelectedValue.ToString();

            // TODO: This line of code loads data into the '_16027_DBDataSet2.Racuni' table. You can move, or remove it, as needed.
            this.racuniTableAdapter1.FillByDatum(this._16027_DBDataSet2.Racuni, datum);
        }
    }
}
