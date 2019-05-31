using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licao3
{
    class Program
    {
        static void Main(string[] args)
        {
            ManipuladorDeArquivo m = new ManipuladorDeArquivo();
            m.CarregarArquivo();
            m.EscreveArquivoCliente();
            m.EscreveArquivoEstado();
            m.EscreveArquivoVeiculo();
            m.EscreveArquivoQuartoArquivo();
            Console.WriteLine("Fim!");
            Console.ReadKey();
        }
    }
}
