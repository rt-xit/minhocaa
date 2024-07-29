public class Cliente
{
      private string CPF;
      private Int64 id;

      public void SetNome (string nome)
      {
         this.CPF = nome;
      }
     
      public string GetCPF ()
      {
        return CPF;
      }
}