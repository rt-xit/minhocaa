public class ItemVenda
{
      public string Produto;
      private Int64 id;

      public void SetNome (string produto)
      {
         this.Produto = produto;
      }
     
      public string GetProduto ()
      {
        return Produto;
      }
}