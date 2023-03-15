using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_08_03
{
    public class Endereco
    {
        public Endereco(int id, int cep, string rua, int numero, string bairro, string cidade)
        {
            Id = id;
            Cep = cep;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;

        }

        private int Id;
        private int Cep;
        private int Numero;
        private string Rua;
        private string Bairro;
        private string Cidade;
        public int getId()
        {
            return Id;
        }
        public void setId(int id)
        {
            Id = id;
        }
        public int getCep()
        {
            return Cep;
        }
        public void setCep(int cep)
        {
            Cep = cep;
        }
        public int getNumero()
        {
            return Numero;
        }
        public void setNumero(int numero)
        {
            Numero = numero;
        }
        public string getRua()
        {
            return Rua;
        }
        public void setRua(string rua)
        {
            Rua = rua;
        }
        public string getBairro()
        {
            return Bairro;
        }
        public void setBairro(string bairro)
        {
            Bairro = bairro;
        }
        public string getCidade()
        {
            return Cidade;
        }
        public void setCidade(string cidade)
        {
            Cidade = cidade;
        }
    }
}
