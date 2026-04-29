using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aulas.Data.Model
{
    /// <summary>
    /// Representa um estudante do sistema, herdando os atributos base de MyUser
    /// </summary>
    public class Student : MyUser
    {
        /// <summary>
        /// Número de estudante
        /// </summary>
        public int StudentNumber { get; set; }

        /// <summary>
        /// atributo auxiliar para a propina, para ser usado na View 
        /// para recolher a propina como string, e depois converter para 
        /// decimal e para ser guardada na bd
        /// </summary>
        [NotMapped] // esta anotação informa a EF para não criar um atributo na bd 
        [Required(ErrorMessage ="A {0} é obrigatória ")]
        [Display(Name= "Propina")]
        [StringLength(10)]
        [RegularExpression("[0-9]{1,7}([,.][0-9]{1,2})?" , ErrorMessage ="A {0} deve ser um número com até 2 casas decimais")]
        public string TuitionFeeAux { get; set; } = "";

        /// <summary>
        /// Valor da propina do estudante
        /// </summary>
        [Precision(9, 2)] // informa a EF para criar o atributo com 9 dígitos e 2 casas decimais  
        public decimal TuitionFee { get; set; }

        /// <summary>
        /// Data de registo do estudante no sistema
        /// </summary>
        [Display(Name = "Data de Registro")]
        [Required(ErrorMessage = "{0} é de preenchimento obrigatório")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        /*********************
         * Relacionamentos 1-N
         *********************/

        /// <summary>
        /// FK para o curso em que o estudante está matriculado
        /// </summary>
        [ForeignKey(nameof(Degree))]
        public int DegreeFK { get; set; }

        /// <summary>
        /// Curso em que o estudante está matriculado
        /// </summary>
        public Degree Degree { get; set; } = null!;

        /*********************
         * Relacionamentos N-M
         *********************/

        /// <summary>
        /// Lista de inscrições do estudante em UCs
        /// </summary>
        public ICollection<Registration> Registrations { get; set; } = new List<Registration>();
    }
}
