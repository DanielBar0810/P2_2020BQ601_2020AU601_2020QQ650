using System.ComponentModel.DataAnnotations;

namespace P2_2020BQ601_2020AU601_2020QQ650.Models
{
    public class Generos
    {
        [Key]
        public int id_genero { get; set; }
        public int nombre_genero { get; set; }
    }
}
