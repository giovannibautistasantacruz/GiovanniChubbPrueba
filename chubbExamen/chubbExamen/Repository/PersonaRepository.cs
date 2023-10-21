using AutoMapper;
using chubbExamen.Data;
using chubbExamen.Models;
using chubbExamen.Models.DTO;
using chubbExamen.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace chubbExamen.Repository
{
    public class PersonaRepository:IPersonaRepository
    {
        private readonly ApplicationDbContext _bd;
        private readonly IMapper _mapper;

        public PersonaRepository(ApplicationDbContext bd, IMapper mapper)
        {
            _bd = bd;
            _mapper = mapper;
        }

        public personaDTO CreatePersona(personaDTO addpersonaDTO)
        {
            try
            {
                
                tbl_Persona persona = new tbl_Persona();
                persona = _mapper.Map<tbl_Persona>(addpersonaDTO);
                var result = _bd.tbl_Persona.Add(persona);
                if (!Guardar())
                {
                    return null;
                }
                return _mapper.Map<personaDTO>(result.Entity);
            }
            catch (Exception _e)
            {
                //Herramienta de loggeo
                return null;
            }
            
        }

        public personaDTO UpdatePersona(personaDTO updatepersonaDTO)
        {
            try
            {
                var person = _bd.tbl_Persona.FirstOrDefault(p=>p.IdPersona == updatepersonaDTO.IdPersona);

                if (person == null)
                {
                    return null;
                }

               
                _bd.Entry<tbl_Persona>(person).State = EntityState.Detached;
                person = _mapper.Map<tbl_Persona>(updatepersonaDTO);
                var result = _bd.Update(person);
                if (!Guardar())
                {
                    return null;
                }
                return _mapper.Map<personaDTO>(result.Entity);
            }
            catch (Exception _e)
            {
                //Herramienta de loggeo
                return null;
            }

        }

        public personaDTO GetPersona(int IdPersona)
        {
            var person = _bd.tbl_Persona.Include(d=>d.Direccion).FirstOrDefault(p => p.IdPersona == IdPersona);

            return _mapper.Map<personaDTO>(person);
        }

        public List<personaDTO> GetPersonas()
        {
            var person = _bd.tbl_Persona.ToList();

            return _mapper.Map<List<personaDTO>>(person);
        }

        public bool Guardar()
        {
            return _bd.SaveChanges() >= 0 ? true : false;
        }
    }
}
