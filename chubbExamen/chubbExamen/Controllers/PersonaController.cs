using AutoMapper;
using chubbExamen.Models.DTO;
using chubbExamen.Models.Generics;
using chubbExamen.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace chubbExamen.Controllers
{
    [Route("api/persona")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaRepository _personaRepository;
        private readonly IMapper _mapper;
        protected ResponseAPI _respuestAPI;

        public PersonaController(IPersonaRepository personaRepository, IMapper mapper)
        {
            _personaRepository = personaRepository;
            _mapper = mapper;
            this._respuestAPI = new();
        }

        [HttpPost("CrearPersona")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CrearAlumno([FromBody] personaDTO personaDTO)
        {
            if (!ModelState.IsValid)
            {
                _respuestAPI.StatusCode = HttpStatusCode.BadRequest;
                _respuestAPI.IsSuccess = false;
                _respuestAPI.ErrorMessages.Add("Por favor verifica la información");
                return BadRequest(_respuestAPI);
            }
            var persona = _personaRepository.CreatePersona(personaDTO);
            if (persona == null)
            {
                _respuestAPI.StatusCode = HttpStatusCode.InternalServerError;
                _respuestAPI.IsSuccess = false;
                _respuestAPI.ErrorMessages.Add("Ocurrio un error al crear la persona");
                return StatusCode(500, _respuestAPI);
            }

            _respuestAPI.StatusCode = HttpStatusCode.Created;
            _respuestAPI.IsSuccess = true;
            _respuestAPI.Result = persona;
            return StatusCode(201, _respuestAPI);
        }

        [HttpPost("ActualizarPersona")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ActualizarPersona([FromBody] personaDTO personaDTO)
        {
            if (!ModelState.IsValid)
            {
                _respuestAPI.StatusCode = HttpStatusCode.BadRequest;
                _respuestAPI.IsSuccess = false;
                _respuestAPI.ErrorMessages.Add("Por favor verifica la información");
                return BadRequest(_respuestAPI);
            }
            var persona = _personaRepository.UpdatePersona(personaDTO);
            if (persona == null)
            {
                _respuestAPI.StatusCode = HttpStatusCode.InternalServerError;
                _respuestAPI.IsSuccess = false;
                _respuestAPI.ErrorMessages.Add("Ocurrio un error al actualizar la persona");
                return StatusCode(500, _respuestAPI);
            }

            _respuestAPI.StatusCode = HttpStatusCode.OK;
            _respuestAPI.IsSuccess = true;
            _respuestAPI.Result = persona;
            return StatusCode(200, _respuestAPI);
        }

        [HttpGet("{personaId}", Name = "GetPersona")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public IActionResult GetPersona(int personaId)
        {
            if (personaId <= 0)
            {
                _respuestAPI.StatusCode = HttpStatusCode.BadRequest;
                _respuestAPI.IsSuccess = false;
                _respuestAPI.ErrorMessages.Add("Por favor verifica la información");
                return BadRequest(_respuestAPI);
            }
            var persona = _personaRepository.GetPersona(personaId);
            if (persona == null)
            {
                _respuestAPI.StatusCode = HttpStatusCode.NotFound;
                _respuestAPI.IsSuccess = false;
                _respuestAPI.ErrorMessages.Add("No se encontro Información");
                return NotFound(_respuestAPI);
            }

            return Ok(persona);
        }

        [HttpGet("GetPersonas")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public IActionResult GetPersonas()
        {
           
            var alumno = _personaRepository.GetPersonas();


            return Ok(alumno);
        }

        [HttpPut("BajaPersona")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BajaPersona([FromBody] int personaId)
        {
            var persona = _personaRepository.DeletePersona(personaId);
            if (persona == null)
            {
                _respuestAPI.StatusCode = HttpStatusCode.BadRequest;
                _respuestAPI.IsSuccess = false;
                _respuestAPI.ErrorMessages.Add("Ocurrio un error al dar de baja la persona");
                return BadRequest(_respuestAPI);
            }

            _respuestAPI.StatusCode = HttpStatusCode.OK;
            _respuestAPI.IsSuccess = true;
            _respuestAPI.Result = persona;
            return Ok(_respuestAPI);
        }
    }
}
