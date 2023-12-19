using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "O nome do lanche deve ser informado")]
        [Display(Name = "Nome do lanche")]
        [StringLength(80,MinimumLength =10,ErrorMessage ="o {0} deve ter no minimo {1} e no máximo {2}")]
        public  string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser informada")]
        [Display(Name ="Descrição do lanche")]
        [MinLength(20, ErrorMessage ="Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage ="Descriçãp não pode execer {1} caracteres")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descrição detalhada do lanche deve ser informada")]
        [Display(Name = "Descrição do lanche")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descriçãp não pode exece^r {1} caracteres")]

        public string DescricaoDetalhada { get; set; }
        [Required]
        [Display(Name ="Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99,ErrorMessage ="O preço deve estar entrew 1 e 999,99")]
        public  decimal Preco { get; set; }

        [Display(Name ="Caminho Image Normal")]
        [StringLength(200,ErrorMessage ="O {0} deve ter no máximo {1} caracteres")]
        public string  ImagemUrl { get; set; }

        [Display(Name = "Caminho Image Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name ="Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name ="Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
