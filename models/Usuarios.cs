using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RunGymFront.Models
{
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [StringLength(50, ErrorMessage = "El apellido no puede tener más de 50 caracteres.")]
        public string Apellido { get; set; }


        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; }


        [Required(ErrorMessage = "El género es obligatorio.")]
        [RegularExpression(@"^[MF]$", ErrorMessage = "El género debe ser 'M' o 'F'.")]
        public char Genero { get; set; }


        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }


        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El email no tiene un formato válido.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "El tipo de usuario es obligatorio.")]
        public string TipoUsuario { get; set; }


        [Range(0, 500, ErrorMessage = "El peso debe estar entre 0 y 500 kg.")]
        public Decimal Peso { get; set; }


        [Range(0, 3, ErrorMessage = "La altura debe estar entre 0 y 3 metros.")]
        public Decimal Altura { get; set; }


        [Range(0, 24, ErrorMessage = "Las horas de sueño deben estar entre 0 y 24 horas.")]
        public Decimal HorasSueno { get; set; }


        [Required(ErrorMessage = "El consumo de agua es obligatorio.")]
        public string ConsumoAgua { get; set; }


        [Range(0, 500, ErrorMessage = "El peso deseado debe estar entre 0 y 500 kg.")]
        public Decimal PesoDeseado { get; set; }


        [Required(ErrorMessage = "El tipo de cuerpo es obligatorio.")]
        public string TipoCuerpo { get; set; }


        [Required(ErrorMessage = "El cuerpo deseado es obligatorio.")]
        public string CuerpoDeseado { get; set; }


        public string ResumenBienestar { get; set; }
    }
}
