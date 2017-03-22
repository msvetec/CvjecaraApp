using System;
using System.Collections.Generic;
using System.Data.Common;

namespace PICvjecara.DBClass
{
    public class Stavka_racuna
    {
        public int ID_stavke_racuna { get; set; }
        public string Naziv { get; set; }
        public int Kolicina { get; set; }
        public float Iznos { get; set; }
        public int ID_korisnika { get; set; }
        public int ID_artikli { get; set; }
        public int sifra_racuna { get; set; }    
        public int BrojStavke { get; set; }    

        public Stavka_racuna()
        {
        }

        public Stavka_racuna(DbDataReader dr)
        {
            if (dr != null)
            {
                Naziv = dr["Naziv"].ToString();
                Iznos = float.Parse(dr["Iznos"].ToString());//float
                Kolicina = int.Parse(dr["Kolicina"].ToString());
                ID_korisnika = int.Parse(dr["ID_korisnika"].ToString());
                ID_artikli = int.Parse(dr["ID_artikli"].ToString());
                sifra_racuna = int.Parse(dr["sifra_racuna"].ToString());
                BrojStavke = int.Parse(dr["ID_stavke_racuna"].ToString());
                //ID_nalog_za_prodaju = int.Parse(dr["ID_nalog_za_prodaju"].ToString());
            }
        }

        public Stavka_racuna(DbDataReader dr, string naziv)
        {
            ID_stavke_racuna  = int.Parse(dr["Redni broj"].ToString());
            ID_artikli = int.Parse(dr["Sifra artikla"].ToString());
            Naziv = dr["Naziv artikla"].ToString();
            Iznos = float.Parse(dr["Iznos"].ToString());//float
            Kolicina = int.Parse(dr["Kolicina"].ToString());
        }

        public int Unos(int brojStavke,int sifra_racuna)
        {
            string sqlUpit = "";
            if (ID_stavke_racuna == 0)
            {
                sqlUpit = "INSERT INTO Stavke_racuna (ID_stavke_racuna, Naziv, Iznos, Kolicina, ID_korisnika, ID_artikli, sifra_racuna) VALUES ('" + brojStavke + "','" + Naziv + "','" + Iznos + "','" + Kolicina + "','" + ID_korisnika + "','" + ID_artikli + "','" + sifra_racuna + "')";
            }

            else
            {
                sqlUpit = "UPDATE Stavke_racuna SET Naziv='" + Naziv + "', Iznos='" + Iznos + "', Kolicina='" + Kolicina + "', ID_korisnika='" + ID_korisnika + "', ID_artikli='" + ID_artikli + "', sifra_racuna = '" + sifra_racuna + " WHERE ID_stavke_racuna=" + ID_stavke_racuna;
            }

            return DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
        }

        public int Obrisi(int brojArtikla)
        {
            string sqlUpit = "";
            sqlUpit = "DELETE FROM Stavke_racuna WHERE ID_artikli=" + brojArtikla;
            return DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
        }

        public int ObrisiSve()
        {
            string sqlUpit = "DELETE FROM Stavke_racuna WHERE ID_artikli=ID_artikli";
            return DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
        }

        public static List<Stavka_racuna> DohvatiSveStavke()
        {
            List<Stavka_racuna> lista = new List<Stavka_racuna>();
            string sqlUpit = "SELECT * FROM Stavke_racuna";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Stavka_racuna stavke = new Stavka_racuna(dr);
                lista.Add(stavke);
            }
            dr.Close();
            return lista;
        }

        public static List<Stavka_racuna> DohvatiOznaceneArtikle(int ID_stavke)
        {
            List<Stavka_racuna> lista = new List<Stavka_racuna>();
            string sqlUpit = "SELECT * FROM Artikli WHERE ID_artikla=" + ID_stavke;
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Stavka_racuna stavke = new Stavka_racuna(dr);
                lista.Add(stavke);
            }
            dr.Close();
            return lista;
        }

        public int UmanjiKolicinuArtikli(int brojArtikla)
        {
            string sqlUpit = "UPDATE Stavke_racuna SET Kolicina = Kolicina - 1 WHERE ID_artikli=" + brojArtikla; 
            return DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
        }

        public int Update()
        {
            string sqlUpit = "UPDATE Stavke_racuna SET Kolicina = Kolicina + 1 WHERE ID_artikli=" + ID_artikli;
            return DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
        }

        public List<Stavka_racuna> DohvatiStavkeZaRacun(int id)
        {
            List<Stavka_racuna> lista = new List<Stavka_racuna>();
            string sqlUpit = "select (select distinct count(ID_artikli) from Stavke_racuna) as 'Broj artikla', sum(Kolicina), sum(iznos), max(ID_korisnika)  from Stavke_racuna  where ID_stavke_racuna = nesto; " + id;
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Stavka_racuna stavke = new Stavka_racuna(dr);
                lista.Add(stavke);
            }
            dr.Close();
            return lista;
        }

        public void PopuniTablicuRacuni(List<Stavka_racuna> listaStavka)
        {
            foreach (Stavka_racuna row in listaStavka)
            {
                string sqlUpit = "INSERT INTO Racuni_tablica (ID_stavke_racuna, Naziv, Iznos, Kolicina, ID_korisnika, ID_artikli, sifra_racuna) VALUES('" + row.BrojStavke + "', '" + row.Naziv + "', '" + row.Iznos + "', '" + row.Kolicina + "', '" + row.ID_korisnika + "', '" + row.ID_artikli + "', '" + row.sifra_racuna + "')";
                DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
            }            
        }
    }
}
