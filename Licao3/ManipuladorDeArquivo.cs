using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licao3
{
    class ManipuladorDeArquivo
    {

        public void CarregarArquivo()
        {
            if (File.Exists("dados.txt"))//verifica se o arquivo dados.txt existe
            {
                try
                {
                    Cliente c = new Cliente();
                    Veiculo v = new Veiculo();
                    Estado e = new Estado();
                    using (StreamReader sr = new StreamReader("dados.txt"))//cria uma instancia para ler o arquivo
                    {
                        string linha;//variavel que recebera as linhas do documento
                        string[] texto = null;//variavel que vai receber o texto entre o ;
                        while ((linha = sr.ReadLine()) != null) //enquanto existir linhas
                        {
                            texto = linha.Split(';');//pega o texto que esta entre ";" e adiciona nos atributos das classes;

                            c.CodCliente.Add(texto[0]);
                            c.NomeCliente.Add(texto[1]);
                            c.Endereco.Add(texto[2]);
                            c.Telefone.Add(texto[3]);
                            c.Cep.Add(texto[4]);
                            c.Cidade.Add(texto[5].ToLower().ToString());
                            c.Estado.Add(texto[6]);
                            v.NomeVeicuo.Add(texto[7]);
                            v.AnoFabricacao.Add(texto[8]);
                            v.Fabricante.Add(texto[9]);
                            e.Cep.Add(texto[4]);
                            e.Cidade.Add(texto[5]);
                            e.Esstado.Add(texto[6]);
                        }
                    }
                    c.CalculoRisco();//chama o metodo calcularisco para atribuir o valor do risco da cidade do cliente
                }
                catch (Exception e)
                {
                    Console.WriteLine("Não é possivel ler o arquivo" + e.Message);
                }
            }
            else
            {
                Console.WriteLine("Arquivo dados.txt não existe!");
            }
        }

        public void EscreveArquivoCliente()
        {
            Cliente c = new Cliente();
            if (c.CodCliente.Count != 0)//quer dizer que nao tinha nenhum dado para escrever
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter("cliente.txt"))//cria uma instancia para escrever no arquivo
                    {
                        for (int i = 0; i < c.CodCliente.Count; i++)//para i ate a quantidade de codigodeCliente ele vai escrever no documento de texto prenchendo
                        {
                            writer.Write(c.CodCliente[i] + ";");
                            writer.Write(c.NomeCliente[i] + ";");
                            writer.Write(c.Endereco[i] + ";");
                            writer.Write(c.Telefone[i] + ";");
                            writer.Write(c.Cep[i] + ";");
                            writer.Write(c.Cidade[i] + ";");
                            writer.Write(c.Estado[i] + ";");
                            writer.WriteLine("");
                        }
                        Console.WriteLine("Arquivo cliente.txt escrito com sucesso!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao escrever no arquivo: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("Nao ha dados para escrever no arquivo cliente.txt");
            }
        }

        public void EscreveArquivoVeiculo()
        {
            Veiculo v = new Veiculo();
            if (v.AnoFabricacao.Count != 0)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter("veiculo.txt"))//cria uma instancia para escrever no arquivo
                    {
                        for (int i = 0; i < v.NomeVeicuo.Count; i++)
                        {
                            writer.Write(v.NomeVeicuo[i] + ";");
                            writer.Write(v.AnoFabricacao[i] + ";");
                            writer.Write(v.Fabricante[i] + ";");
                            writer.WriteLine("");
                        }
                        Console.WriteLine("Arquivo veiculo.txt escrito com sucesso!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao escrever no arquivo: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("Nao ha dados para escrever no arquivo veiculo.txt");
            }
        }

        public void EscreveArquivoEstado()
        {
            Estado e = new Estado();
            if (e.Cep.Count != 0)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter("estado.txt"))//cria uma instancia para escrever no arquivo
                    {
                        for (int i = 0; i < e.Cep.Count; i++)
                        {
                            writer.Write(e.Cep[i] + ";");
                            writer.Write(e.Cidade[i] + ";");
                            writer.Write(e.Esstado[i] + ";");
                            writer.WriteLine("");
                        }
                        Console.WriteLine("Arquivo estado.txt escrito com sucesso!");
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("Erro ao escrever no arquivo: ");
                }
            }
            else
            {
                Console.WriteLine("Nao ha dados para escrever o arquivo estado.txt");
            }
        }


        public void EscreveArquivoQuartoArquivo()
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
                Console.WriteLine("nao havia dados para inserir no quarto arquivo");
            }
        }

    }
}
