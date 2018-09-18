using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestShot.Model;
using ListarUsuario = UnitTestShot.Model.Dao;

namespace UnitTestShot
{
    [TestClass]
    public class UnitTestShoting
    {

        [TestMethod]
        public void TestMethodInicial()
        {
            Debug.WriteLine("Abrindo Jogo");
            var jogo = new Jogo();
            Debug.WriteLine("Iniciando Jogo");
            jogo.IniciarJogo();
            jogo.VerificarPontuacao();
            Debug.WriteLine("Carregando configuração do Jogo");
            jogo.CarregarConfiguracao();
            jogo.VerificarPontuacao();
            Debug.WriteLine("Verificando a configuração dos personagens para serem removidos");
            jogo.VerificarPersonagens();
            jogo.VerificarPontuacao();
            Debug.WriteLine("Verificando as armas mais utilizadas");
            jogo.VerArmasMaisUtilizadas();
            Debug.WriteLine("Fim Jogo");


        }

    }
}
