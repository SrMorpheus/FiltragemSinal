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
    public class ControllerFiltro
    {

        private readonly IFiltroRepository _repository;



        public ControllerFiltro ()
        {
            _repository = new FiltroRepositoryImplementation();

        }




        public void SalvarDados(ModelFiltro modelFiltro)
        {

            _repository.Criar(modelFiltro);

        }


        public List<ModelFiltro> GetDados()
        {

            return _repository.GetFiltros();

        }







    }
}
