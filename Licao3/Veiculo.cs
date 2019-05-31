using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licao3
{
    class Veiculo
    {
        private ArrayList nomeVeicuo = new ArrayList();
        private ArrayList anoFabricacao = new ArrayList();
        private ArrayList fabricante = new ArrayList();

        public ArrayList NomeVeicuo { get => nomeVeicuo; set => nomeVeicuo = value; }
        public ArrayList AnoFabricacao { get => anoFabricacao; set => anoFabricacao = value; }
        public ArrayList Fabricante { get => fabricante; set => fabricante = value; }
        
    }
}
