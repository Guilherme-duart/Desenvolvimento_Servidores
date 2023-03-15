using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Desenvolvimento_de_Servidores
{
    public class Veiculos
    {
        public int numeroRodas;
        public int numeroPortas;
        public string cor;
        public int quantidadeAcentos;
        public bool PagaImposto;

        public string ExibirDados()
        {
            return "N portas:" + numeroPortas + "cor:" + cor;
        }
    }


}
