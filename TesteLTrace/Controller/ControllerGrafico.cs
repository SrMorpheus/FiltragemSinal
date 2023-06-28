using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteLTrace.Models;
using TesteLTrace.Repository.Contract;
using TesteLTrace.Repository.Implementations;

namespace TesteLTrace.Controller
{
    public class ControllerGrafico
    {


        private readonly IGraficoRepository _repository;



        public ControllerGrafico()
        {
            _repository = new GraficoRepositoryImplementation();

        }




        public void SalvarDados( ModelGrafico modelGrafico)
        {

            _repository.Criar(modelGrafico);

        }

        public void SalvarVariosDados(double[] resultados, int idFiltros)
        {


            foreach(var resultado in resultados)
            {
                ModelGrafico grafico = new ModelGrafico(resultado, 4000, idFiltros);

                _repository.Criar(grafico);


            }





        }

        public List<ModelGrafico> GetDados()
        {

            return _repository.GetGrafico();

        }


        public List<ModelGrafico> GetDadosId()
        {

            return _repository.GetGrafico().Where(I => I.ModelFiltroId == 1).ToList() ;

        }

    }
}
