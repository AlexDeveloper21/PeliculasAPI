﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.EntityFrameworkCore;
using PeliculasAPI.DTOs;
using PeliculasAPI.Entidades;
using PeliculasAPI.Utilidades;

namespace PeliculasAPI.Controllers
{
    [Route("api/generos")]
    [ApiController]
    public class GenerosController : CustomBaseController
    {
        private readonly IOutputCacheStore outputCacheStore;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private const string cacheTag = "generos";

        public GenerosController(IOutputCacheStore outputCacheStore, ApplicationDbContext context, IMapper mapper)
            :base(context, mapper, outputCacheStore, cacheTag)
        {
            this.outputCacheStore = outputCacheStore;
            this.context = context;
            this.mapper = mapper;
        }


        //[HttpGet("paginados")] //api/generos
        //[OutputCache(Tags = [cacheTag])]
        //public List<GeneroDTO> obtenerTodos()
        //{
        //    return new List<GeneroDTO> { new GeneroDTO { Id = 1, Nombre = "Comedia" }, new GeneroDTO { Id = 2, Nombre = "Acción" } };
        //}
        
        //[HttpGet("todos")] //api/generos/todos
        //[OutputCache(Tags = [cacheTag])]
        //public List<GeneroDTO> obtenerTodos()
        //{
        //    return new List<GeneroDTO> { new GeneroDTO { Id = 1, Nombre = "Comedia" }, new GeneroDTO { Id = 2, Nombre = "Acción" } };
        //}



        [HttpGet] //api/generos
        [OutputCache(Tags = [cacheTag])]
        public async Task<List<GeneroDTO>> Get([FromQuery] PaginacionDTO paginacion)
        {
            return await Get<Genero, GeneroDTO>(paginacion, ordenarPor: g => g.Id);

        }

        [HttpGet("todos")] //api/generos/todos
        [OutputCache(Tags = [cacheTag])]
        public async Task<List<GeneroDTO>> Get()
        {
            return await Get<Genero, GeneroDTO>(ordenarPor: g => g.Id);

        }

        [HttpGet("{id:int}", Name = "ObtenerGeneroPorId")]
        [OutputCache(Tags = [cacheTag])]
        public async Task<ActionResult<GeneroDTO>> Get(int id)
        {
            return await Get<Genero, GeneroDTO>(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GeneroCreacionDTO generoCreacionDTO)
        {
            return await Post<GeneroCreacionDTO, Genero, GeneroDTO> (generoCreacionDTO, "ObtenerGeneroPorId");
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, [FromBody] GeneroCreacionDTO generoCreacionDTO)
        {
            return await Put<GeneroCreacionDTO, Genero>(id, generoCreacionDTO);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return await Delete<Genero>(id);
        }

        


    }
}