using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe
{
    public class Mulher : Pessoa
    {
        public Mulher(string nomeCompleto) : base(nome:string.Empty, sobrenome:string.Empty, sexo:Sexo.feminino)
        {
            // barbara kosela
            string[] nomePreenchido = nomeCompleto.Split(' ');
            // 0 - barbara
            // 1 - kosela

            string nome = nomePreenchido[0];
            string sobrenome = nomePreenchido[1];

            this.Validar(nome, sobrenome);
            this.MudarNome(nome, sobrenome);

        }

    }
}
