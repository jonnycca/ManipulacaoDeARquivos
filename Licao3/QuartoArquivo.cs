using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licao3
{
    class QuartoArquivo
    {
        public void EscreveArquivo()
        {
            Cliente c = new Cliente();
            if (c.CodCliente.Count != 0)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter("quartoArquivo.txt"))//cria uma instancia para escrever no arquivo
                    {
                        for (int i = 0; i < c.Cidade.Count; i++)
                        {
                            writer.Write(c.CodCliente[i].ToString() + ";");
                            writer.Write(c.NomeCliente[i] + ";");
                            writer.Write(c.Risco[i] + ";");
                            writer.WriteLine("");
                        }
                        Console.WriteLine("Arquivo quartoARquivo.txt escrito com sucesso!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao escrever no arquivo: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("nao a dados para inserir o quarto arquivo!");
            }
        }
    }
}
