using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RunGymFront.Models
{
    public class Ejercicios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        [ForeignKey("Rutina")]
        public int IdRutina { get; set; }


        [Required]
        [StringLength(100)]
        public string Nombre_Ejercicio { get; set; }


        [StringLength(500)]
        public string Descripcion { get; set; }
    }
}