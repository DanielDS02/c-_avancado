using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio
{
    public enum TamanhoDePizza
    {
        Pequena = 0,
        Média = 1,
        Grande = 2,
    }


    public class Pizza
    {
        public string Sabor { get; set; }
        public TamanhoDePizza TamanhoDePizza { get; set; }
        public string Descricao {  get; set; }
        public int Id { get; set; }
        public double Preco { get; set; } 

        public Pizza()
        {
            
        }

        public string DefinirSabor(string sabor)
        {
            if(sabor == "C")
            {
                sabor = "Calabresa";
            }
            else if (sabor == "F")
            {
                sabor = "Frango";
            }
            return sabor;
        }

        public string DefinirTamanho(string tamanho)
        {
            switch(tamanho)
            {
                case "P":
                    {
                        TamanhoDePizza = TamanhoDePizza.Pequena;
                        Preco = 50.0;
                        break;
                    }
                case "M":
                    {
                        TamanhoDePizza = TamanhoDePizza.Média;
                        Preco = 65.0;
                        break;
                    }
                case "G":
                    {
                        TamanhoDePizza = TamanhoDePizza.Grande;
                        Preco = 80.0;
                        break;
                    }
                default:
                    {
                        throw new Exception("Tamanho não definido");
                    }
            }

            return Enum.GetName(TamanhoDePizza);
        }

        public override string ToString()
        {
            return $"Sua Pizza é de sabor {Sabor} e tamanho {TamanhoDePizza}";  
        }

    }
}
