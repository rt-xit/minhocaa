public class Pessoa
{
      private string CPF;
      private Int64 id;
      public string nome;

      public void SetNome (string nome)
      {
         this.CPF = nome;
      }
     
      public string GetCPF ()
      {
        return CPF;
      }
}