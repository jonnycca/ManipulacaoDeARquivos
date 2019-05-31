using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licao3
{
    class Cliente
    {
        private static ArrayList codCliente = new ArrayList();
        private static ArrayList nomeCliente = new ArrayList();
        private static ArrayList endereco = new ArrayList();
        private static ArrayList telefone = new ArrayList();
        private static ArrayList cep = new ArrayList();
        private static ArrayList cidade = new ArrayList();
        private static ArrayList Esstado = new ArrayList();
        private static ArrayList risco = new ArrayList();

        public ArrayList Risco { get => risco; set => risco = value; }
        public ArrayList CodCliente { get => codCliente; set => codCliente = value; }
        public ArrayList NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public ArrayList Endereco { get => endereco; set => endereco = value; }
        public ArrayList Telefone { get => telefone; set => telefone = value; }
        public ArrayList Cep { get => cep; set => cep = value; }
        public ArrayList Cidade { get => cidade; set => cidade = value; }
        public ArrayList Estado { get => Esstado; set => Esstado = value; }

        //calcular risco da cidade, jogar depois de criar a cidade
        public void CalculoRisco()
        {
            risco.Add("Risco");//adicionando o titulo
            for (int i = 1; i < cidade.Count; i++)//para cada cidade
            {
                GeraRisco(cidade[i].ToString());//gera um risco e atribui ao atributo
            }
        }

        public void GeraRisco(string cidade)//switch para pegar as cidades e retornar o valor
        {
            switch (cidade)
            {
                case "uberlandia":
                    risco.Add("ALTO");
                    break;
                case "ituiutaba":
                    risco.Add("BAIXO");
                    break;
                case "capinopolis":
                    risco.Add("MEDIO");
                break;
                default:
                    risco.Add("Altissimo");
                break;
            }
        }
    }
}
