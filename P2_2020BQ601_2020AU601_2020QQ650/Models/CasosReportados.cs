using System.ComponentModel.DataAnnotations;
namespace P2_2020BQ601_2020AU601_2020QQ650.Models
{
    public class CasosReportados
    {
        [Key]
        public int id_caso { get; set; }
        public int id_departamento { get; set; }
        public int id_genero { get; set; }
        public int casosConfirmados { get; set; }
        public int casosRecuperados { get; set; }
        public int casosFallecidos { get; set; }

    }
}
