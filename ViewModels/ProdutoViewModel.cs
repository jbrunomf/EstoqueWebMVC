using System.Collections.Generic;
using EstoqueWeb.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EstoqueWeb.ViewModels;

public class ProdutoViewModel
{
    public ICollection<ProdutoModel>? Produtos { get; set; }
    public SelectList? Categorias { get; set; }
    public string? CategoriaProduto { get; set; }
    public string? TextoBusca { get; set; }
}