using System.ComponentModel.DataAnnotations;

namespace Aulas.Data.Model{

    public class Degree{

        [Key]
        public int Id {get; set;}

        // O ="" faz com que ao criar o atributo seja atribuido a string vazia
        [Required(ErrorMessage="Prenchimento Obrigatório")]
        [StringLength(100)]
        public string Name { get; set; } = "";

        // ? ao pe do string permite que o atributo seja nulo
        [StringLength(50)]
        public string? Logotype {get; set;} 


    }
}
