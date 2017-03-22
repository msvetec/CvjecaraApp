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
    public partial class frmEvidencijaZaposlenika : Form
    {
        private int sifraKorisnika;
        public frmEvidencijaZaposlenika()
        {
            InitializeComponent();
        }

        private void frmEvidencijaZaposlenika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16027_DBDataSet.Korisnici' table. You can move, or remove it, as needed.
            this.korisniciTableAdapter.Fill(this._16027_DBDataSet.Korisnici);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                sifraKorisnika = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
                
                // TODO: This line of code loads data into the '_16027_DBDataSet.Dobavljaci' table. You can move, or remove it, as needed.
                this.dobavljaciTableAdapter.Fill(this._16027_DBDataSet.Dobavljaci);
                // TODO: This line of code loads data into the '_16027_DBDataSet.Kupci' table. You can move, or remove it, as needed.
                this.kupciTableAdapter.Fill(this._16027_DBDataSet.Kupci);
                // TODO: This line of code loads data into the '_16027_DBDataSet.Narudzbenica' table. You can move, or remove it, as needed.
                this.narudzbenicaTableAdapter.FillBykorisnik(this._16027_DBDataSet.Narudzbenica, sifraKorisnika);
                // TODO: This line of code loads data into the '_16027_DBDataSet.Nalog_za_prodaju' table. You can move, or remove it, as needed.
                this.nalog_za_prodajuTableAdapter.FillBykorisnik(this._16027_DBDataSet.Nalog_za_prodaju, sifraKorisnika);
                // TODO: This line of code loads data into the '_16027_DBDataSet.Tip_korisnika' table. You can move, or remove it, as needed.
                this.tip_korisnikaTableAdapter.Fill(this._16027_DBDataSet.Tip_korisnika);
                

            }
        }
    }
}
