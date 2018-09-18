using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestShot.Model
{
    public abstract class Dados
    {
        public static List<Usuario> usuarios { get; set; }

        public Dados()
        {
            if (usuarios==null) { 
            usuarios = new List<Usuario>();
            this.PreencherLista();
            }
        }

        public void PreencherLista()
        {

            Cadastrar(new Usuario
            {
                Id = 1,
                Nome = "Joao",
                Pontos = 4,
                Arma = "HK"
            });

            Cadastrar(new Usuario
            {
                Id = 2,
                Nome = "Maria",
                Pontos = 5,
                Arma = "12"
            });

            Cadastrar(new Usuario
            {
                Id = 3,
                Nome = "Pedro",
                Pontos = 6,
                Arma = "HK"
            });
        }

        public void Cadastrar(Usuario usr)
        {
            var usuario = usuarios.FirstOrDefault(p=>p.Id==usr.Id);
            if (usuario == null)
            {
                usuarios.Add(usr);
            }
            else
            {
                this.RemoverCadastro(usr);
            }
                
        }

        public void RemoverCadastro(Usuario usr)
        {
            Dados.usuarios.Remove(usr);
        }
    }
}
