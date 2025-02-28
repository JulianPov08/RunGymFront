using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RunGymFront.Models
{
    public class Metas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }


        [Required]
        [StringLength(100)]
        [Display(Name = "Meta Principal")]
        public string MetaPrincipal { get; set; }


        [StringLength(500)]
        [Display(Name = "Cuerpo Actual")]
        public string CuerpoActual { get; set; }


        [StringLength(500)]
        [Display(Name = "Cuerpo Deseado")]
        public string CuerpoDeseado { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "Última vez que tuvo el cuerpo ideal")]
        public DateTime Ultimavez_CuerpoIdeal { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Inicio")]
        public DateTime FechaInicio { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Fin")]
        public DateTime FechaFin { get; set; }


        [Range(0, 100)]
        [Display(Name = "Progreso")]
        public int Progreso { get; set; }


        [NotMapped]
        public string ResumenMeta => $"{MetaPrincipal} - {Progreso}%";
    }
}