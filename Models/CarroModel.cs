using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CarroModel
    {
        public string Nome { get; set; }
        public string Cor { get; set; }
        public DateTime Fabricação  { get; set; }
        public string Preço { get; set; }

        public static List<CarroModel> CriarLista()
        {
            var lista = new List<CarroModel>();
            lista.Add(new CarroModel() { Nome = "Rolls-Royce Boat Tail", Cor = "Azul", Fabricação = DateTime.Parse("2013/02/23") , Preço= "R$142.774.800" });
            lista.Add(new CarroModel() { Nome = "Bugatti La Voiture Noire", Cor = "Cinza", Fabricação = DateTime.Parse ("2005/10/02"), Preço = "R$ 65.268.480", });
            lista.Add(new CarroModel() { Nome = "Bugatti Centodieci", Cor = "Branco", Fabricação = DateTime.Parse("2019/05/25"), Preço = "R$ 45.891.900" });
            lista.Add(new CarroModel() { Nome = "Mercedes-Maybach Exelero", Cor = "Preto", Fabricação = DateTime.Parse("2004/04/09"), Preço = "R$ 40.792.800" });




            return lista;
        }



    }
}
