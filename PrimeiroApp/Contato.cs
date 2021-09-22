using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroApp
{
    struct Contato
    {
        public string nome;
        public string sobrenome;
        public string tipocontato;
        public string telefone;
        public string email;
        public string bairro;
        public string cidade;
        public string estado;
        public DateTime dataniver;
        public string obs;

        public Contato(string nome, string sobrenome, string tipocontato, string telefone, string email, string bairro, string cidade, string estado, DateTime dataniver, string obs)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.tipocontato = tipocontato;
            this.telefone = telefone;
            this.email = email;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.dataniver = dataniver;
            this.obs = obs;

        }
            

    }
}
