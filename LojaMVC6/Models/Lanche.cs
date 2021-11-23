using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaMVC6.Models;

public class Lanche
{
    public int LancheId { get; set; }
    [StringLength(100)]
    public string NomeLanche { get; set; }
    [StringLength(100)]
    public string DescricaoCurta { get; set; }
    [StringLength(255)]
    public string DescricaoDetalhada { get; set; }
    [Column(TypeName="decimal(18,2)")]
    public decimal Preco { get; set; }
    public string ImagemUrl { get; set; }
    public string ImagemThumbnailUrl { get; set; }
    public bool IsLanchePreferido { get; set; }
    public bool EmEstoque { get; set; }
    public int CategoriaId { get; set; }
    public virtual Categoria Categoria { get; set; }
}

