using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PICvjecara.DBClass;

namespace PICvjecara
{
    public partial class frmUnosNovogArtikla : Form
    {
        Artikl artikli = new Artikl();
        public frmUnosNovogArtikla()
        {
            InitializeComponent();
        }

        private void frmUnosNovogArtikla_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16027_DBDataSet.Vrsta_artikla' table. You can move, or remove it, as needed.
            this.vrsta_artiklaTableAdapter.Fill(this._16027_DBDataSet.Vrsta_artikla);

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int broj = 0;
            if (int.TryParse(txtCijena.Text.Trim(), out broj) && int.TryParse(txtKolicina.Text.Trim(), out broj))
            {
                artikli.ID_vrsta_artikla = int.Parse(cmboxTipArtikla.SelectedValue.ToString());
                artikli.Naziv = txtNaziv.Text;
                artikli.Cijena = int.Parse(txtCijena.Text);
                artikli.Kolicina = int.Parse(txtKolicina.Text);
                artikli.Unos();

                if (MessageBox.Show("Uspiješno ste unijeli artikl: " + artikli.Naziv + "\nŽelite li unijeti novi artikl?", "Provjera", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    cmboxTipArtikla.Text = "Tip artikla";
                    txtNaziv.Text = "Naziv artikla";
                    txtCijena.Text = "Cijena artila";
                    txtKolicina.Text = "Kolicina artikla";
                }
                else
                {
                    if (ActiveMdiChild != null)
                    {
                        ActiveMdiChild.Close();
                    }

                    frmPregledArtikla pregledArtikla = new frmPregledArtikla();
                    pregledArtikla.MdiParent = frmPregledArtikla.ActiveForm;
                    pregledArtikla.Show();
                }                    
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
    }
}
