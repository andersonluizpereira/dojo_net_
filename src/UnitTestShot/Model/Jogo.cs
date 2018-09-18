using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestShot.Model
{
    public class Jogo : IJogo
    {
        private VisualizarDados visualizarDados;
        

        public void IniciarJogo()
        {
            var jogar = new Dao();
           
        }

        public void CarregarConfiguracao()
        {
            var ler = new LerArquivo();
        }

        public void VerificarPontuacao()
        {
            visualizarDados = new VisualizarDados();
            visualizarDados.VisualizarPontuacao();
        }
        public void VerArmasMaisUtilizadas()
        {
            visualizarDados = new VisualizarDados();
            visualizarDados.VerArmasMaisUtilizadas();
        }

        public void VerificarPersonagens()
        {
            Dao.VerificarPersonagensLista();
        }
    }
}
