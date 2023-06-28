using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLTrace.Models.Comtext
{
    public  class TesteLTraceContext : DbContext
    {
        private const string V = "Server=localhost;DataBase=TesteDados;Uid=root";

        public DbSet<ModelFiltro> ModelFiltros { get; set; }
        public DbSet<ModelGrafico> ModelGraficos { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.EnableSensitiveDataLogging();
           optionsBuilder.UseMySql(V, new MySqlServerVersion(new Version(8, 0, 28)));

        }
            
        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ModelFiltro>().HasData(

                new ModelFiltro { Id = 1, HighPass = 1, LowPass = 1 }
                
                
                
                );

            modelBuilder.Entity<ModelGrafico>().HasData(

                new ModelGrafico { Id =1010, DadosSismico = -4.7469604e-7, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =2, DadosSismico = -1.306379e-6, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =3, DadosSismico = 5.5409564e-6, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =4, DadosSismico = 3.520742e-5, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id = 5,  DadosSismico = 5.2020758e-5, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =6, DadosSismico = 6.0402552e-5, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =7, DadosSismico = -4.3129519e-5, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =8, DadosSismico = -0.0001125016, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =9, DadosSismico = -0.00018260432, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =10, DadosSismico = -0.00015841764, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =11, DadosSismico = -0.00011617896, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =12, DadosSismico = -0.00013290522, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =13, DadosSismico = -0.00037435323, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =14, DadosSismico = -0.00068153447, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =15, DadosSismico = -0.00031832643, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =16, DadosSismico = 0.00046329558, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =17, DadosSismico = -0.00037943243, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =18, DadosSismico = -0.00378769, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =19, DadosSismico = -0.00547472, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =20, DadosSismico = 0.00042749097, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =21, DadosSismico = 0.01129542, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =22, DadosSismico = 0.01534481, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =23, DadosSismico = 0.00580368, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =24, DadosSismico = -0.00856397, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =25, DadosSismico = -0.01388226, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =26, DadosSismico = -0.00761286, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =27, DadosSismico = 0.00137434, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =28, DadosSismico = 0.00595682, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =29, DadosSismico = 0.00596679, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =30, DadosSismico = 0.0031812, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =31, DadosSismico = -0.00125056, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =41, DadosSismico = -0.00466955, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =51, DadosSismico = -0.00398068, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =61, DadosSismico = -6.5110777e-5, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =71, DadosSismico = 0.00263525, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =81, DadosSismico = 0.00135817, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =91, DadosSismico = -0.00222557, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =101, DadosSismico = -0.00419043, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =201, DadosSismico = -0.00252298, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =301, DadosSismico = 0.00150468, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =401, DadosSismico = 0.00427969, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =501, DadosSismico = 0.00348717, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =601, DadosSismico = 0.00047537009, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =701, DadosSismico = -0.00111418, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =801, DadosSismico = -0.00012526485, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =901, DadosSismico = 0.00067645544, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =32, DadosSismico = -0.00110193, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =33, DadosSismico = -0.00380943, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =34, DadosSismico = -0.00426841, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =35, DadosSismico = -0.00202688, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =36, DadosSismico = 0.0010157, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =37, DadosSismico = 0.00342666, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =38, DadosSismico = 0.00453182, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =39, DadosSismico = 0.00341483, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =40, DadosSismico = -9.0311965e-5, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =42, DadosSismico = -0.00399398, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =43, DadosSismico = -0.00504003, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =44, DadosSismico = -0.00176624, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =45, DadosSismico = 0.00331933, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =46, DadosSismico = 0.00576494, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =47, DadosSismico = 0.00382156, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =48, DadosSismico = 0.0001423753, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =49, DadosSismico = -0.00211393, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =50, DadosSismico = -0.00250719, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =52, DadosSismico = -0.00185713, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =53, DadosSismico = -0.00013720396, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =54, DadosSismico = 0.00231429, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =55, DadosSismico = 0.00343645, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =56, DadosSismico = 0.00150276, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =57, DadosSismico = -0.00219182, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =58, DadosSismico = -0.00395536, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =59, DadosSismico = -0.00174808, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =60, DadosSismico = 0.00208693, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =62, DadosSismico = 0.00311306, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =63, DadosSismico = 4.1200336e-5, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =65, DadosSismico = -0.00379334, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =64, DadosSismico = -0.00467363, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =66, DadosSismico = -0.00218674, Tempo = 4000, ModelFiltroId = 1 },

                                new ModelGrafico { Id =1, DadosSismico = 0.00148802, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =67, DadosSismico = 0.00418122, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =68, DadosSismico = 0.00460599, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =69, DadosSismico = 0.00209465, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =70, DadosSismico = -0.00219807, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =72, DadosSismico = -0.00469068, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =73, DadosSismico = -0.00215968, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =76, DadosSismico = 0.00351081, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =78, DadosSismico = 0.00612001, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =79, DadosSismico = 0.00310432, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =80, DadosSismico = -0.00089744007, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =810, DadosSismico = -0.00096810103, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =82, DadosSismico = 0.00038296447, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =83, DadosSismico = -0.00236524, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =84, DadosSismico = -0.0079986, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =85, DadosSismico = -0.00873421, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =86, DadosSismico = -0.00056528149, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =87, DadosSismico = 0.01055785, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =88, DadosSismico = 0.01466104, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =89, DadosSismico = 0.00731156, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =90, DadosSismico = -0.00676257, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =92, DadosSismico = -0.01739577, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =93, DadosSismico = -0.01596056, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =94, DadosSismico = -0.00286475, Tempo = 4000, ModelFiltroId = 1 },

                    new ModelGrafico { Id =95, DadosSismico = 0.01101428, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =96, DadosSismico = 0.01418228, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =97, DadosSismico = 0.00656275, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =98, DadosSismico = -0.00172098, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =99, DadosSismico = -0.00346449, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =102, DadosSismico = -0.00097349909, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =103, DadosSismico = 0.00043476542, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =104, DadosSismico = -0.00024356153, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =106, DadosSismico = -0.00087278237, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =107, DadosSismico = -0.00062934903, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =108, DadosSismico = -0.00022400485, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =109, DadosSismico = -0.00018248211, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =112, DadosSismico = -0.00022873518, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =113, DadosSismico = -0.00019961091, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =114, DadosSismico = -0.00019236178, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =115, DadosSismico = -0.00014879073, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =116, DadosSismico = -9.5523988e-5, Tempo = 4000, ModelFiltroId = 1 },
                new ModelGrafico { Id =117, DadosSismico = -1.2213283e-5, Tempo = 4000, ModelFiltroId = 1 },
                    new ModelGrafico { Id =118, DadosSismico = 1.0215717e-5, Tempo = 4000, ModelFiltroId = 1 }
                ); 

        }

    }
}
