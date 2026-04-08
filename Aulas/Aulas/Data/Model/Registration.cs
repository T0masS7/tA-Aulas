using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aulas.Data.Model
{
    /// <summary>
    /// Representa a inscrição de um aluno numa unidade curricular (relacionamento N-M entre Student e Course)
    /// </summary>
    [PrimaryKey(nameof(StudentFK), nameof(CourseFK))]
    public class Registration
    {
        /// <summary>
        /// Data em que o aluno se inscreveu na UC
        /// </summary>
        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        /*********************
         * Relacionamentos 1-N
         *********************/

        /// <summary>
        /// FK para o aluno inscrito
        /// </summary>
        public int StudentFK { get; set; }

        /// <summary>
        /// Aluno inscrito na UC
        /// </summary>
        public Student Student { get; set; } = null!;

        /// <summary>
        /// FK para a UC em que o aluno se inscreveu
        /// </summary>
        public int CourseFK { get; set; }

        /// <summary>
        /// UC em que o aluno se inscreveu
        /// </summary>
        public Course Course { get; set; } = null!;
    }
}
