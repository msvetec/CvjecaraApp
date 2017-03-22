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
    public partial class frmAzurirajArtikl : Form
    {
        Artikl artikli = new Artikl();
        public frmAzurirajArtikl(List<Artikl> lista)
        {
            InitializeComponent();

            artikli.ID_artikla = lista[0].ID_artikla;
            cmboxTipArtikla.SelectedValue = lista[0].ID_vrsta_artikla;
            txtNaziv.Text = lista[0].Naziv;
            txtCijena.Text = lista[0].Cijena.ToString();
            txtKolicina.Text = lista[0].Kolicina.ToString();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            int broj = 0;
            if (int.TryParse(txtCijena.Text.Trim(), out broj) && int.TryParse(txtKolicina.Text.Trim(), out broj))
            {
                artikli.ID_artikla = artikli.ID_artikla;
                artikli.ID_vrsta_artikla = int.Parse(cmboxTipArtikla.SelectedValue.ToString());
                artikli.Naziv = txtNaziv.Text;
                artikli.Cijena = int.Parse(txtCijena.Text);
                artikli.Kolicina = int.Parse(txtKolicina.Text);
                artikli.Unos();

                cmboxTipArtikla.Text = "Tip artikla";
                txtNaziv.Text = "Naziv artikla";
                txtCijena.Text = "Cijena artila";
                txtKolicina.Text = "Kolicina artikla";

                if (ActiveMdiChild != null)
                {
                    ActiveMdiChild.Close();
                }

                frmPregledArtikla pregledArtikla = new frmPregledArtikla();
                pregledArtikla.MdiParent = frmPregledArtikla.ActiveForm;
                pregledArtikla.Show();

                MessageBox.Show("Uspiješno ste uredili artikl: " + artikli.Naziv);
            }

            else
            {
                MessageBox.Show("Cijena i količina moraju biti brojevi");
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            cmboxTipArtikla.Text = "Odaberi tip";
            txtNaziv.Text = "Naziv artikla";
            txtCijena.Text = "Unesite cijenu u kn";
            txtKolicina.Text = "Unesite količinu";
        }

        private void btnPovratak1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmPregledArtikla pregledArtikla = new frmPregledArtikla();
            pregledArtikla.MdiParent = frmPregledArtikla.ActiveForm;
            pregledArtikla.Show();
        }

        private void frmAzurirajArtikl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16027_DBDataSet.Vrsta_artikla' table. You can move, or remove it, as needed.
            this.vrsta_artiklaTableAdapter.Fill(this._16027_DBDataSet.Vrsta_artikla);

        }
    }
}
