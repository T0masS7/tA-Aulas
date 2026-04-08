using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aulas.Data.Model
{
    /// <summary>
    /// Representa uma unidade curricular (UC) do sistema
    /// </summary>
    public class Course
    {
        /// <summary>
        /// PK
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome da unidade curricular
        /// </summary>
        [StringLength(30)]
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} é de preenchimento obrigatório")]
        public string Name { get; set; } = "";

        /// <summary>
        /// Ano curricular em que a UC é lecionada
        /// </summary>
        public int CurricularYear { get; set; }

        /// <summary>
        /// Semestre em que a UC é lecionada
        /// </summary>
        public int Semester { get; set; }

        /*********************
         * Relacionamentos 1-N
         *********************/

        /// <summary>
        /// FK para o curso (Degree) ao qual a UC pertence
        /// </summary>
        [ForeignKey(nameof(Degree))]
        public int DegreeFK { get; set; }

        /// <summary>
        /// Curso ao qual a UC pertence
        /// </summary>
        public Degree Degree { get; set; } = null!;

        /*********************
         * Relacionamentos N-M
         *********************/

        /// <summary>
        /// Lista de professores que lecionam esta UC
        /// </summary>
        public ICollection<Professor> Professors { get; set; } = new List<Professor>();

        /// <summary>
        /// Lista de inscrições de alunos nesta UC
        /// </summary>
        public ICollection<Registration> Registrations { get; set; } = new List<Registration>();
    }
}
