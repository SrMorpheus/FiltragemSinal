using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLTrace.Models
{
    public class ModelFiltro
    {



        public int Id { get; set; } 

        public double LowPass { get ; set; }

        public double HighPass { get ; set; }  

        public List<ModelGrafico> Resultados { get; set; }




        public ModelFiltro() { }

        public ModelFiltro( double lowPass, double highPass)

        { 

            LowPass = lowPass;

            HighPass = highPass;
        
        }




    }
}
