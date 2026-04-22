using System.ComponentModel.DataAnnotations;

namespace Aulas.Data.Model
{
    /// <summary>
    /// Representa um utilizador base do sistema, com atributos comuns a todos os tipos de utilizador
    /// </summary>
    public class MyUser
    {
        /// <summary>
        /// PK
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome do utilizador
        /// </summary>
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} é de preenchimento obrigatório")]
        [StringLength(50)]
        public string Name { get; set; } = "";

        /// <summary>
        /// Data de nascimento do utilizador
        /// </summary>
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Required(ErrorMessage ="A {0} é de preenchimento obrigatório")]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Número de telemóvel do utilizador
        /// </summary>
        [StringLength(17)]
        [Display(Name = "Número de Telefone")]
        [Required(ErrorMessage = "{0} é de preenchimento obrigatório")]
        [RegularExpression(@"\+?[0-9]{9-18}")]   //9[1236][0-9]{7} e fixo [23][0-9]{8}
        public string CellPhone { get; set; } = "";

        /// <summary>
        /// Identificador do utilizador no sistema de autenticação (opcional)
        /// </summary>
        [StringLength(50)]
        public string? UserID { get; set; }
    }
}
