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
        /// Valor da propina do estudante
        /// </summary>
        [Precision(8, 2)]
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
