using System.ComponentModel.DataAnnotations;

namespace P2_2020BQ601_2020AU601_2020QQ650.Models
{
    public class Departamentos
    {
        [Key]
        public int id_departamento { get; set; }
        public string nombre_departamento { get; set; }
    }
}
