using System.ComponentModel.DataAnnotations;

namespace Aulas.Data.Model
{
    /// <summary>
    /// Representa um curso (licenciatura/mestrado) disponível na instituição
    /// </summary>
    public class Degree
    {
        /// <summary>
        /// PK
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome do curso
        /// </summary>
        [Required(ErrorMessage = "Preenchimento Obrigatório")]
        [StringLength(100)]
        public string Name { get; set; } = "";

        /// <summary>
        /// Nome do ficheiro do logótipo do curso (opcional)
        /// </summary>
        [StringLength(50)]
        public string? Logotype { get; set; }
    }
}
