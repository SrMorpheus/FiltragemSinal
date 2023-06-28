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
    public class GraficoRepositoryImplementation : IGraficoRepository
    {

        private readonly TesteLTraceContext _context;


        public GraficoRepositoryImplementation()
        {

            _context = new TesteLTraceContext();

        }


        public void Criar(ModelGrafico modelGrafico)
        {

            _context.Add(modelGrafico);
            _context.SaveChanges();

        }

        public List<ModelGrafico> GetGrafico()
        {

            var getGrafico = _context.ModelGraficos;

            return getGrafico.ToList();

        }
    }
}
