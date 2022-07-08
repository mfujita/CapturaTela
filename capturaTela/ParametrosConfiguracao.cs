using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capturaTela
{
    class ParametrosConfiguracao
    {
        public int superior { get; private set; }
        public int esquerdo { get; private set; }
        public int largura { get; private set; }
        public int altura { get; private set; }
        public int milissegundos { get; private set; }

        public ParametrosConfiguracao(int _s, int _e, int _l, int _a, int _m)
        {
            superior = _s;
            esquerdo = _e;
            largura = _l;
            altura = _a;
            milissegundos = _m;
        }
    }
}
