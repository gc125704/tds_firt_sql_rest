namespace Teste.API.Models
{

    public class Product
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public string Categoria { get; set; }

        public Product(int? id, string nome,decimal preco,int quantidade,string categoria)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Categoria = categoria;
        }

    }
}
