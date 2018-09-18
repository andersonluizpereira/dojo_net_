using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListarUsuario = UnitTestShot.Model.Dao;

namespace UnitTestShot.Model
{
   public class VisualizarDados : Dao, IDao
    {
        public VisualizarDados()
        {
            Debug.WriteLine("\n");
        }

        public void VisualizarPontuacao()
        {
            foreach (var lista in OrdernarPontuacao(ListarUsuario.usuarios))
            {
                Debug.WriteLine(DateTime.Now +" Nome : " + lista.Nome + " Pontuação :" + lista.Pontos + " Armas preferidas " + lista.Arma);
            }
        }

        public void VerArmasMaisUtilizadas()
        {
            foreach (var armasMaisUtilizadas in ArmasMaisUtilizadas())
            {
                foreach (var armas in armasMaisUtilizadas)
                {
                    Debug.WriteLine(DateTime.Now +" "+armas.Arma +" do personagem "+armas.Nome);
                }
            }
        }
        
    }
}
