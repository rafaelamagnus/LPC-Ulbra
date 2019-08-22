namespace teste
{
    public class Usuario
    {

        public string nome { get; private set; }
        public string local { get; private set; }
        public string telefone { get; private set; }
        public string senha { get; private set; }

        public Usuario(string nome, string local, string telefone, string senha)
        {
            this.nome = nome;
            this.local = local;
            this.telefone = telefone;
            this.senha = senha;
        }

        public bool FazReserva(){
          return true;
        }
        
        }
    }