using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICvjecara.DBClass
{
    public class Racuni
    {
        public int br_racuna { get; set; }
        public int sifra_racuna { get; set; }
        public DateTime datum { get; set; }

        public Racuni()
        {
        }

        public Racuni(DbDataReader dr)
        {
            if (dr != null)
            {
                br_racuna = int.Parse(dr["br_racuna"].ToString());
                sifra_racuna = int.Parse(dr["sifra_racuna"].ToString());
                datum = Convert.ToDateTime(dr["Datum"]);
            }
        }

        public Racuni(DbDataReader dr, string datumHelp)
        {
            if (dr != null)
            {
                datum = Convert.ToDateTime(dr["Datum"]);
            }
        }

        public int Unos(int sifra_racuna, DateTime datum)
        {
            string sqlUpit = "";
            if (br_racuna == 0)
            {
                string dan = datum.Day.ToString();
                string mj = datum.Month.ToString();
                string god = datum.Year.ToString();
                string cijeliDatum = mj + "/" + dan + "/" + god;
                sqlUpit = "INSERT INTO Racuni (sifra_racuna, datum) VALUES ('" + sifra_racuna + "','" + cijeliDatum + "')";
            }

            return DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
        }

        public static List<Racuni> DohvatiSveStavke()
        {
            List<Racuni> lista = new List<Racuni>();
            string sqlUpit = "SELECT * FROM Stavke_racuna";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Racuni racuni = new Racuni(dr);
                lista.Add(racuni);
            }
            dr.Close();
            return lista;
        }

        public static object DohvatiBrRacuna()
        {
            string sqlUpit = "Select ISNULL(max(sifra_racuna), 0) from Racuni";
            return DatabaseConnection.Instance.DohvatiVrijednosti(sqlUpit);
        }

        public static List<string> DohvatiDisDatum()
        {
            List<Racuni> lista = new List<Racuni>();
            List<string> listaDatuma = new List<string>();
            string sqlQuery = "SELECT DISTINCT Datum FROM Racuni";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(sqlQuery);
            while (dr.Read())
            {
                Racuni racuni = new Racuni(dr, "");
                lista.Add(racuni);
            }
            dr.Close();

            foreach (Racuni row in lista)
            {
                string dan = row.datum.Day.ToString();
                string mj = row.datum.Month.ToString();
                string god = row.datum.Year.ToString();

                string cijeliDatum = dan + "." + mj + "." + god;
                listaDatuma.Add(cijeliDatum);
            }

            return listaDatuma;
        }
    }
}
