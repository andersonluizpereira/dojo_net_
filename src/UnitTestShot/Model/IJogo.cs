using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestShot.Model
{
    public interface IJogo
    {
        void IniciarJogo();
        void CarregarConfiguracao();
        void VerificarPontuacao();
        void VerificarPersonagens();
        void VerArmasMaisUtilizadas();
    }
}
