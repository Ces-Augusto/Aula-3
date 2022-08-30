using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Aluno
    {
        //declaraçao de atributo
        string nome;
        string cpf;
        string endereco;
        int ra;
        //declaraçao de metodos getter e setter
         public void SetNome(String nome)
        {
            this.nome = nome;
        }
        public string GetNome()
        {
            return this.nome;
        }
        public void SetCpf(String cpf)
        {
            this.cpf = cpf;
        }
        public string GetCpf()
        {
            return this.cpf;
        }
        public void SetEndereco(String endereco)
        {
            this.endereco = endereco;
        }
        public string GetEndereco()
        {
            return this.endereco;
        }
        public void SetRa(int ra)
        {
            this.ra = ra;
        }
        public int GetRa()
        {
            return this.ra;
        }
    }
}
