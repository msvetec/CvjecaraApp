using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICvjecara.DBClass
{
    public class StatistikaRada
    {

        public int ID_statistika_rada { get; set; }
        public DateTime Od { get; set; }
        public DateTime Do { get; set; }
        public int ID_korisnici { get; set; }     

        public static BindingList<StatistikaRada> listaArtikla = new BindingList<StatistikaRada>();
 

        public StatistikaRada()
        {
        }

        public StatistikaRada(DbDataReader dr)
        {
            if (dr != null)
            {
                this.ID_statistika_rada = int.Parse(dr["ID_statistika_rada"].ToString());
                this.Od = Convert.ToDateTime(dr["Od"]);
                this.Do = Convert.ToDateTime(dr["Do"]);
                this.ID_korisnici = int.Parse(dr["ID_korisnici"].ToString());
            }
        }

        public int Unos(int sifrakorisnika, DateTime datumprijave)
        {
            string sqlUpit = "";
            if (ID_statistika_rada == 0)
            {
                sqlUpit = "INSERT INTO Statistika_rada (ID_statistika_rada, Od, Do, ID_korisnici) VALUES ('" + ID_statistika_rada + "','" + datumprijave + "','" + Do + "','" + sifrakorisnika + "')";
            }

           
            return DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
        }

       
        public static List<StatistikaRada> Dohvati()
        {
            List<StatistikaRada> lista = new List<StatistikaRada>();
            string sqlUpit = "SELECT * FROM Statistika_rada";
            DbDataReader dr = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                StatistikaRada statistika = new StatistikaRada(dr);
                lista.Add(statistika);
            }
            dr.Close();
            return lista;
        }

     
    

}
}
