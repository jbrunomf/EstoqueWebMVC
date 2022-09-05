using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstoqueWeb.Models
{
    public class ProdutoModel
    {
        [Key]
        public int IdProduto { get; set; }

        [Required, MaxLength(128)]
        public string Nome { get; set; }

        [MaxLength(10, ErrorMessage = "O Código deve conter até 10 caractéres."), Display(Name = "Código")]
        public string Codigo { get; set; }

        public int Estoque { get; set; }

        public double Preco { get; set; }
        
        public int IdCategoria { get; set; }

        [ForeignKey("IdCategoria")]
        public CategoriaModel Categoria { get; set; }
    }
}