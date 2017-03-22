using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using PICvjecara.DBClass;

namespace PICvjecara
{
    public partial class frmPregledArtikla : Form
    {
        public Artikl artikli;
        public Vrsta_artikla vrstaArtikla;
        public OpenFileDialog fileDialog;
        public List<Vrsta_artikla> listaVsrtaArtikla;

        public frmPregledArtikla()
        {
            InitializeComponent();
            ControlBox = false;
        }

        public void OsvijeziArtikle()
        {
            // TODO: This line of code loads data into the '_16027_DBDataSet1.Vrsta_artikla' table. You can move, or remove it, as needed.
            this.vrsta_artiklaTableAdapter1.Fill(this._16027_DBDataSet1.Vrsta_artikla);
            // TODO: This line of code loads data into the '_16027_DBDataSet1.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter1.Fill(this._16027_DBDataSet1.Artikli);
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            frmCvjecarna openCvjecarna = new frmCvjecarna();
            openCvjecarna.ShowDialog();
            this.Close();
        }

        private void btnUnosNovogArtikla_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmUnosNovogArtikla frmUnosNovogArtikla = new frmUnosNovogArtikla();
            frmUnosNovogArtikla.MdiParent = frmUnosNovogArtikla.ActiveForm;
            frmUnosNovogArtikla.Show();

            OsvijeziArtikle();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            List<Artikl> lista = new List<Artikl>();
            if (artikliDataGridView.SelectedRows.Count > 0)
            {
                int odabraniArtikl = int.Parse(artikliDataGridView.SelectedCells[0].Value.ToString());                
                lista = Artikl.DohvatiArtikle(odabraniArtikl);
            }

            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmAzurirajArtikl frmAzurirajArtikl = new frmAzurirajArtikl(lista);
            frmAzurirajArtikl.MdiParent = frmAzurirajArtikl.ActiveForm;
            frmAzurirajArtikl.Show();

            OsvijeziArtikle();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            artikli = new Artikl();
            int obrisiArikl = 0;

            if (MessageBox.Show("Želite li obrisati artikl?" , "Provjera", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (artikliDataGridView.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = artikliDataGridView.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = artikliDataGridView.Rows[selectedRowIndex];
                    obrisiArikl = int.Parse(selectedRow.Cells[0].Value.ToString());
                }

                artikliDataGridView.Rows.RemoveAt(artikliDataGridView.CurrentRow.Index);   
                artikli.Obrisi(obrisiArikl);
            }
            OsvijeziArtikle();
        }

        private void artikliDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (artikliDataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = artikliDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = artikliDataGridView.Rows[selectedRowIndex];
                txtBrisanjeArtikla.Text = Convert.ToString(selectedRow.Cells[0].Value);
            }
        }

        private void PregledArtikla_Load(object sender, EventArgs e)
        {
            OsvijeziArtikle();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            vrstaArtikla = new Vrsta_artikla();
            listaVsrtaArtikla = new List<Vrsta_artikla>();
            listaVsrtaArtikla = vrstaArtikla.DohvatiVrstuArtikla();

            int broj = 0;
            for (int i = 0; i < listaVsrtaArtikla.Count; i++)
            {
                if (listaVsrtaArtikla[i].Vrsta == txtVrsta.Text)
                {
                    broj++;
                }
            }
            //int broj = vrstaArtikla.DohvatiVrstuPoID(txtVrsta.Text);
            if (broj == 0)
            {
                vrstaArtikla.Vrsta = txtVrsta.Text;
                vrstaArtikla.Unos();
                OsvijeziArtikle();
                txtVrsta.Text = "";
                MessageBox.Show("Kategorija uspiješno unesena!");
            }
            else
            {
                MessageBox.Show("Kategorija vec postoji");
            }
        }
    }
}
