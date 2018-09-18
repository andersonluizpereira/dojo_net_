using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.IO;
using ListarUsuario = UnitTestShot.Model.Dao;

namespace UnitTestShot.Model
{
    public  class LerArquivo
    {
        public LerArquivo()
        {
            BuscarArquivo();
        }

        public void BuscarArquivo()
        {
            var lines = File.ReadAllLines(@ConfigurationManager.AppSettings["localarquivo"].ToString());

            for (long i = 1; i < lines.Count(); i++)
            {
                var column = lines[i].Split(';');

                var usr = new Usuario
                {
                    Id = ListarUsuario.PegarUltimoId(),
                    Nome = column[0],
                    Pontos = Convert.ToInt32(column[1]),
                    Arma = column[2],
                };
                ListarUsuario.usuarios.Add(usr);
            }
            
        }
    }
}
