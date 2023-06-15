using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleDeContatos.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do produto")]
        public string Nome { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PrecoCompra { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PrecoVenda { get; set; }
        [Required]
        public int Quantidade { get; set; }

        public decimal TotalParaVenda()
        {
            return PrecoVenda * Quantidade;
        }
    }

}
