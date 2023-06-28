using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteLTrace.Models;

namespace TesteLTrace.Repository.Contract
{
    public interface IGraficoRepository
    {

        void Criar(ModelGrafico modelGrafico);

        List<ModelGrafico> GetGrafico();


    }
}
