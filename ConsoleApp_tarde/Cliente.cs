using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_08_03
{
    public class Cliente
    {
        public Cliente(int IdSeed, string name, string telefone)
        {
            Id = IdSeed;
            IdSeed++;
            Name = name;
            Telefone = telefone;
        }
        private static int IdSeed = 1;
        private int Id;
        private string Name;
        private string Telefone;

        public int getId()
        {
            return Id;
        }
        public void setId(int id)
        {
            Id = id;
        }
        public string getName()
        {
            return Name;
        }
        public void setName(string name)
        {
            Name = name;
        }
        public string getTelefone()
        {
            return Telefone;
        }
        public void setTelefone(string telefone)
        {
            Telefone = telefone;
        }
    }
}
