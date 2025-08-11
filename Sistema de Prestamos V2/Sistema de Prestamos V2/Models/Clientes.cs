using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Prestamos_V2.Models
{
    public class Clientes
    {
        [Required(ErrorMessage = "El campo ID es obligatorio.")]
        [Display(Name = "ID del Cliente")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Cedula es obligatorio.")]
        [Display(Name = "Cedula del Cliente")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio. ")]
        [Display(Name = "Nombre")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Apellido es obligatorio. ")]
        [Display(Name = "Apellido")]
        [StringLength(100)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo Correo es obligatorio. ")]
        [Display(Name = "Correo Electrónico")]
        [EmailAddress]
        public string CorreoElectronico { get; set; }

        [Required(ErrorMessage = "El campo Telefono es obligatorio. ")]
        [Display(Name = "Teléfono")]
        [Phone]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo Dirección es obligatorio. ")]
        [StringLength(200)]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El campo Fecha de Nacimiento es obligatorio")]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "El campo Nacionalidad es obligatorio. ")]
        [Display(Name = "Nacionalidad")]
        [StringLength(50)]
        [DataType(DataType.Text)]
        public string Nacionalidad { get; set; }

        [Required(ErrorMessage = "El campo Estado Civil es obligatorio. ")]
        [Display(Name = "Estado Civil")]
        [StringLength(50)]
        public string EstadoCivil { get; set; }

        [Required(ErrorMessage = "El campo Ocupación es obligatorio. ")]
        [Display(Name = "Ocupación")]
        [StringLength(100)]
        public string Ocupacion { get; set; }

        // Relación
        public ICollection<Prestamos> Prestamos { get; set; }
    }
}
