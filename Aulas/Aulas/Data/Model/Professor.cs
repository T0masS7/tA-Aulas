namespace Aulas.Data.Model
{
    /// <summary>
    /// Representa um professor do sistema, herdando os atributos base de MyUser
    /// </summary>
    public class Professor : MyUser
    {
        /*********************
         * Relacionamentos N-M
         *********************/

        /// <summary>
        /// Lista de UCs lecionadas pelo professor
        /// </summary>
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
