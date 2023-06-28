using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteLTrace.Models;
using TesteLTrace.Models.Comtext;
using TesteLTrace.Repository.Contract;

namespace TesteLTrace.Repository.Implementations
{
    public class FiltroRepositoryImplementation : IFiltroRepository
    {

        private readonly TesteLTraceContext _context;


        public FiltroRepositoryImplementation()
        {

            _context = new TesteLTraceContext();

        }


   
        public void Criar(ModelFiltro modelFiltro)
        {

            _context.Add(modelFiltro);

            _context.SaveChanges();

        }

        public List<ModelFiltro> GetFiltros()
        {

            var getFiltros = _context.ModelFiltros.Include(G => G.Resultados);


            return getFiltros.ToList();

        }

        public List<ModelGrafico> GetGrafico()
        {

            var getGrafico = _context.ModelGraficos.ToList();

            return getGrafico;

        }
    }
}
