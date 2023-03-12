using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOrientacaoObjeto
{
    public class Pessoa
    {
        private int Id;
        private string Name;
        private string Telefone;

        public Pessoa(int id, string name, string telefone)
        {
            Id = id;
            Name = name;
            Telefone = telefone;
        }
    }
}
