using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLTrace.Models
{
    public class ModelGrafico
    {


        public int? Id { get; set; }

        public double DadosSismico { get; set; }

        public double Tempo { get; set; }

        public int ModelFiltroId { get; set; }



        public ModelGrafico() { }



        public ModelGrafico(double dados, double tempo, int idFiltro )
        {
            DadosSismico = dados;

            Tempo = tempo;


            ModelFiltroId = idFiltro; 

        }




    }



    


}
