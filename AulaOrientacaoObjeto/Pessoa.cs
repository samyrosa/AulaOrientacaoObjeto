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

        public int getId()
        {
            return Id;
        }

        public string getName()
        {
            return Name;
        }

        public string getTelefone()
        {
            return Telefone;
        }

        public void setId(int id)
        {
            Id = id;
        }

        public void setNome(string nome)
        {
            Name = nome;
        }

        public void setTelefone(string telefone)
        {
            Telefone = telefone;
        }
    }
}
