using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarmotaApi.Models
{
    [Table("Agendamento")]
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdAgen { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Cinema { get; set; }
        [Required]
        public int Sala { get; set; }
        [Required]
        public int Sessão { get; set; }
        [Required]
        public string Filme { get; set; }
    }
}