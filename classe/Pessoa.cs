using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe
{
    public class Pessoa
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public Sexo sexoInformado { get; private set; }
        public Pessoa(string nome, string sobrenome, Sexo sexo)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            sexoInformado = sexo;

            //Validar();
        }
        public void MudarNome(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;

            //Validar();
        }
        public void Exibir()
        {
            Console.WriteLine($"\nSeu resultado é: " + Nome.Trim() + " " + Sobrenome.Trim() + " Com o sexo: " + sexoInformado);
        }
        #region Regra de negocio
        protected void Validar(string nomeCompleto)
        {
            if (string.IsNullOrEmpty(nomeCompleto))
                throw new Exception("Nome completo deve ser preenchido");
            if (!nomeCompleto.Contains(" "))
                throw new Exception("Nome deve ser completo");
        }
        #endregion
    }
}
