using PeliculasAPI.Entidades;

namespace PeliculasAPI.DTOs
{
    public class PeliculasPostgetDTO
    {
        public List<GeneroDTO> Generos { get; set; } = new List<GeneroDTO>();
        public List<CineDTO> Cines { get; set; } = new List<CineDTO>();
        
    }
}
