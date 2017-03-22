namespace PICvjecara
{
    partial class frmEvidencijaZaposlenika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dobavljaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16027_DBDataSet = new PICvjecara._16027_DBDataSet();
            this.narudzbenicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kupciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nalogzaprodajuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDkorisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDtipkorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tipkorisnikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisniciTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.KorisniciTableAdapter();
            this.tableAdapterManager = new PICvjecara._16027_DBDataSetTableAdapters.TableAdapterManager();
            this.dobavljaciTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.DobavljaciTableAdapter();
            this.kupciTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.KupciTableAdapter();
            this.nalog_za_prodajuTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.Nalog_za_prodajuTableAdapter();
            this.narudzbenicaTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.NarudzbenicaTableAdapter();
            this.tip_korisnikaTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.Tip_korisnikaTableAdapter();
            this.dBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbenicaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbenicaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.datumvrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDdobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDkorisniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDnarudzbeniceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDkupciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDkorisnikDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDnalogzaprodajuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nalogzaprodajuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipkorisnikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDkorisnikDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.gradDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.iDtipkorisnikaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.korisniciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(745, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datumDataGridViewTextBoxColumn,
            this.iDkupciDataGridViewTextBoxColumn,
            this.iDkorisnikDataGridViewTextBoxColumn1,
            this.iDnalogzaprodajuDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.nalogzaprodajuBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 226);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(347, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datumvrijemeDataGridViewTextBoxColumn,
            this.iDdobavljacDataGridViewTextBoxColumn,
            this.iDkorisniciDataGridViewTextBoxColumn,
            this.iDnarudzbeniceDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.narudzbenicaBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(443, 226);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(354, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // dobavljaciBindingSource
            // 
            this.dobavljaciBindingSource.DataMember = "Dobavljaci";
            this.dobavljaciBindingSource.DataSource = this._16027_DBDataSet;
            // 
            // _16027_DBDataSet
            // 
            this._16027_DBDataSet.DataSetName = "_16027_DBDataSet";
            this._16027_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // narudzbenicaBindingSource
            // 
            this.narudzbenicaBindingSource.DataMember = "Narudzbenica";
            this.narudzbenicaBindingSource.DataSource = this._16027_DBDataSet;
            // 
            // kupciBindingSource
            // 
            this.kupciBindingSource.DataMember = "Kupci";
            this.kupciBindingSource.DataSource = this._16027_DBDataSet;
            // 
            // nalogzaprodajuBindingSource
            // 
            this.nalogzaprodajuBindingSource.DataMember = "Nalog_za_prodaju";
            this.nalogzaprodajuBindingSource.DataSource = this._16027_DBDataSet;
            // 
            // iDkorisnikDataGridViewTextBoxColumn
            // 
            this.iDkorisnikDataGridViewTextBoxColumn.DataPropertyName = "ID_korisnik";
            this.iDkorisnikDataGridViewTextBoxColumn.HeaderText = "ID_korisnik";
            this.iDkorisnikDataGridViewTextBoxColumn.Name = "iDkorisnikDataGridViewTextBoxColumn";
            this.iDkorisnikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // gradDataGridViewTextBoxColumn
            // 
            this.gradDataGridViewTextBoxColumn.DataPropertyName = "Grad";
            this.gradDataGridViewTextBoxColumn.HeaderText = "Grad";
            this.gradDataGridViewTextBoxColumn.Name = "gradDataGridViewTextBoxColumn";
            this.gradDataGridViewTextBoxColumn.Visible = false;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.Visible = false;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // iDtipkorisnikaDataGridViewTextBoxColumn
            // 
            this.iDtipkorisnikaDataGridViewTextBoxColumn.DataPropertyName = "ID_tip_korisnika";
            this.iDtipkorisnikaDataGridViewTextBoxColumn.DataSource = this.tipkorisnikaBindingSource;
            this.iDtipkorisnikaDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.iDtipkorisnikaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDtipkorisnikaDataGridViewTextBoxColumn.HeaderText = "Tip korisnika";
            this.iDtipkorisnikaDataGridViewTextBoxColumn.Name = "iDtipkorisnikaDataGridViewTextBoxColumn";
            this.iDtipkorisnikaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDtipkorisnikaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDtipkorisnikaDataGridViewTextBoxColumn.ValueMember = "ID_tip_korisnika";
            // 
            // tipkorisnikaBindingSource
            // 
            this.tipkorisnikaBindingSource.DataMember = "Tip_korisnika";
            this.tipkorisnikaBindingSource.DataSource = this._16027_DBDataSet;
            // 
            // korisniciBindingSource
            // 
            this.korisniciBindingSource.DataMember = "Korisnici";
            this.korisniciBindingSource.DataSource = this._16027_DBDataSet;
            // 
            // korisniciTableAdapter
            // 
            this.korisniciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtikliTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DobavljaciTableAdapter = this.dobavljaciTableAdapter;
            this.tableAdapterManager.KorisniciTableAdapter = this.korisniciTableAdapter;
            this.tableAdapterManager.KupciTableAdapter = this.kupciTableAdapter;
            this.tableAdapterManager.Nalog_za_prodajuTableAdapter = this.nalog_za_prodajuTableAdapter;
            this.tableAdapterManager.NarudzbenicaTableAdapter = this.narudzbenicaTableAdapter;
            this.tableAdapterManager.Racuni_tablicaTableAdapter = null;
            this.tableAdapterManager.RacuniTableAdapter = null;
            this.tableAdapterManager.RezervacijaTableAdapter = null;
            this.tableAdapterManager.Statistika_radaTableAdapter = null;
            this.tableAdapterManager.Stavke_narudzbeniceTableAdapter = null;
            this.tableAdapterManager.Stavke_racunaTableAdapter = null;
            this.tableAdapterManager.Stavke_rezervacijeTableAdapter = null;
            this.tableAdapterManager.Tip_korisnikaTableAdapter = this.tip_korisnikaTableAdapter;
            this.tableAdapterManager.Tip_rezervacijeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PICvjecara._16027_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vrsta_artiklaTableAdapter = null;
            // 
            // dobavljaciTableAdapter
            // 
            this.dobavljaciTableAdapter.ClearBeforeFill = true;
            // 
            // kupciTableAdapter
            // 
            this.kupciTableAdapter.ClearBeforeFill = true;
            // 
            // nalog_za_prodajuTableAdapter
            // 
            this.nalog_za_prodajuTableAdapter.ClearBeforeFill = true;
            // 
            // narudzbenicaTableAdapter
            // 
            this.narudzbenicaTableAdapter.ClearBeforeFill = true;
            // 
            // tip_korisnikaTableAdapter
            // 
            this.tip_korisnikaTableAdapter.ClearBeforeFill = true;
            // 
            // dBDataSetBindingSource
            // 
            this.dBDataSetBindingSource.DataSource = this._16027_DBDataSet;
            this.dBDataSetBindingSource.Position = 0;
            // 
            // narudzbenicaBindingSource1
            // 
            this.narudzbenicaBindingSource1.DataMember = "Narudzbenica";
            this.narudzbenicaBindingSource1.DataSource = this._16027_DBDataSet;
            // 
            // narudzbenicaBindingSource2
            // 
            this.narudzbenicaBindingSource2.DataMember = "Narudzbenica";
            this.narudzbenicaBindingSource2.DataSource = this._16027_DBDataSet;
            // 
            // datumvrijemeDataGridViewTextBoxColumn
            // 
            this.datumvrijemeDataGridViewTextBoxColumn.DataPropertyName = "datum_vrijeme";
            this.datumvrijemeDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumvrijemeDataGridViewTextBoxColumn.Name = "datumvrijemeDataGridViewTextBoxColumn";
            this.datumvrijemeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // iDdobavljacDataGridViewTextBoxColumn
            // 
            this.iDdobavljacDataGridViewTextBoxColumn.DataPropertyName = "ID_dobavljac";
            this.iDdobavljacDataGridViewTextBoxColumn.DataSource = this.dobavljaciBindingSource;
            this.iDdobavljacDataGridViewTextBoxColumn.DisplayMember = "Ime";
            this.iDdobavljacDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDdobavljacDataGridViewTextBoxColumn.HeaderText = "Dobavljac";
            this.iDdobavljacDataGridViewTextBoxColumn.Name = "iDdobavljacDataGridViewTextBoxColumn";
            this.iDdobavljacDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDdobavljacDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDdobavljacDataGridViewTextBoxColumn.ValueMember = "ID_dobavljac";
            // 
            // iDkorisniciDataGridViewTextBoxColumn
            // 
            this.iDkorisniciDataGridViewTextBoxColumn.DataPropertyName = "ID_korisnici";
            this.iDkorisniciDataGridViewTextBoxColumn.HeaderText = "ID_korisnici";
            this.iDkorisniciDataGridViewTextBoxColumn.Name = "iDkorisniciDataGridViewTextBoxColumn";
            this.iDkorisniciDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDnarudzbeniceDataGridViewTextBoxColumn
            // 
            this.iDnarudzbeniceDataGridViewTextBoxColumn.DataPropertyName = "ID_narudzbenice";
            this.iDnarudzbeniceDataGridViewTextBoxColumn.HeaderText = "ID_narudzbenice";
            this.iDnarudzbeniceDataGridViewTextBoxColumn.Name = "iDnarudzbeniceDataGridViewTextBoxColumn";
            this.iDnarudzbeniceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // iDkupciDataGridViewTextBoxColumn
            // 
            this.iDkupciDataGridViewTextBoxColumn.DataPropertyName = "ID_kupci";
            this.iDkupciDataGridViewTextBoxColumn.DataSource = this.kupciBindingSource;
            this.iDkupciDataGridViewTextBoxColumn.DisplayMember = "Prezime";
            this.iDkupciDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDkupciDataGridViewTextBoxColumn.HeaderText = "Kupac";
            this.iDkupciDataGridViewTextBoxColumn.Name = "iDkupciDataGridViewTextBoxColumn";
            this.iDkupciDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDkupciDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDkupciDataGridViewTextBoxColumn.ValueMember = "ID_kupca";
            // 
            // iDkorisnikDataGridViewTextBoxColumn1
            // 
            this.iDkorisnikDataGridViewTextBoxColumn1.DataPropertyName = "ID_korisnik";
            this.iDkorisnikDataGridViewTextBoxColumn1.HeaderText = "ID_korisnik";
            this.iDkorisnikDataGridViewTextBoxColumn1.Name = "iDkorisnikDataGridViewTextBoxColumn1";
            this.iDkorisnikDataGridViewTextBoxColumn1.Visible = false;
            // 
            // iDnalogzaprodajuDataGridViewTextBoxColumn
            // 
            this.iDnalogzaprodajuDataGridViewTextBoxColumn.DataPropertyName = "ID_nalog_za_prodaju";
            this.iDnalogzaprodajuDataGridViewTextBoxColumn.HeaderText = "ID_nalog_za_prodaju";
            this.iDnalogzaprodajuDataGridViewTextBoxColumn.Name = "iDnalogzaprodajuDataGridViewTextBoxColumn";
            this.iDnalogzaprodajuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmEvidencijaZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 407);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmEvidencijaZaposlenika";
            this.Text = "frmEvidencijaZaposlenika";
            this.Load += new System.EventHandler(this.frmEvidencijaZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nalogzaprodajuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipkorisnikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _16027_DBDataSet _16027_DBDataSet;
        private System.Windows.Forms.BindingSource korisniciBindingSource;
        private _16027_DBDataSetTableAdapters.KorisniciTableAdapter korisniciTableAdapter;
        private _16027_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _16027_DBDataSetTableAdapters.Tip_korisnikaTableAdapter tip_korisnikaTableAdapter;
        private System.Windows.Forms.BindingSource tipkorisnikaBindingSource;
        private _16027_DBDataSetTableAdapters.Nalog_za_prodajuTableAdapter nalog_za_prodajuTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource dBDataSetBindingSource;
        private System.Windows.Forms.BindingSource nalogzaprodajuBindingSource;
        private _16027_DBDataSetTableAdapters.NarudzbenicaTableAdapter narudzbenicaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource narudzbenicaBindingSource;
        private _16027_DBDataSetTableAdapters.KupciTableAdapter kupciTableAdapter;
        private System.Windows.Forms.BindingSource kupciBindingSource;
        private System.Windows.Forms.BindingSource narudzbenicaBindingSource2;
        private System.Windows.Forms.BindingSource narudzbenicaBindingSource1;
        private _16027_DBDataSetTableAdapters.DobavljaciTableAdapter dobavljaciTableAdapter;
        private System.Windows.Forms.BindingSource dobavljaciBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDkorisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDtipkorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDkupciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDkorisnikDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDnalogzaprodajuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumvrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDdobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDkorisniciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDnarudzbeniceDataGridViewTextBoxColumn;
    }
}