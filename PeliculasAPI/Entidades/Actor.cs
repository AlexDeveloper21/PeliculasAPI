using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.Entidades
{
    public class Actor : IId
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }
        public DateTime fechaNacimiento { get; set; }
        [Unicode(false)]
        public string? Foto { get; set; }
    }

}
