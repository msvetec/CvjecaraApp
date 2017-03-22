using System;
using System.Collections.Generic;
using System.Data.Common;

namespace PICvjecara.DBClass
{
    class StavkePoRacunima
    {
        public int Redni_broj { get; set; }
        public int Sifra_artikla { get; set; }
        public string Naziv_artikla { get; set; }
        public int Kolicina { get; set; }
        public float Iznos { get; set; }
        

        public StavkePoRacunima()
        {
        }

        public StavkePoRacunima(DbDataReader dr)
        {
            if (dr != null)
            {
                Redni_broj = int.Parse(dr["Redni broj"].ToString());
                Sifra_artikla = int.Parse(dr["Sifra artikla"].ToString());
                Naziv_artikla = dr["Naziv artikla"].ToString();
                Iznos = float.Parse(dr["Iznos"].ToString());//float
                Kolicina = int.Parse(dr["Kolicina"].ToString());
            }
        }

        public List<StavkePoRacunima> StavkeZaPrikazRacuna(int sifraRacuna)
        {
            List<StavkePoRacunima> lista = new List<StavkePoRacunima>();
            string sqlUpit = "select s.ID_stavke_racuna as 'Redni broj', s.ID_artikli as 'Sifra artikla', s.Naziv as 'Naziv artikla', s.Kolicina, s.Iznos, s.sifra_racuna from Racuni r join Racuni_tablica s on (r.sifra_racuna = s.sifra_racuna) where r.sifra_racuna = " + sifraRacuna;
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                StavkePoRacunima stavke = new StavkePoRacunima(dr);
                lista.Add(stavke);
            }

            dr.Close();
            return lista;
        }
    }
}
