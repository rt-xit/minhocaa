public class LocalizacaoDespacho
{
       public string Estado;

       public string Cidade;

       public string Bairro;

       public string Rua;

       public int Número;

       private Int64 id;

      public void SetNome (string estado)
      {
         this.Estado = estado;
      }
     
      public string GetNome ()
      {
        return Estado;
      }

}