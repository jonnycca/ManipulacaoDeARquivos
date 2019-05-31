using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licao3
{
    class Estado
    {
        private static ArrayList cep = new ArrayList();
        private static ArrayList cidade = new ArrayList();
        private static ArrayList estado = new ArrayList();

        public ArrayList Cep { get => cep; set => cep = value; }
        public ArrayList Cidade { get => cidade; set => cidade = value; }
        public ArrayList Esstado { get => estado; set => estado = value; }

    }
}
