using chubbExamen.Models.DTO;

namespace chubbExamen.Repository.IRepository
{
    public interface IPersonaRepository
    {
        personaDTO CreatePersona(personaDTO addpersonaDTO);
        personaDTO UpdatePersona(personaDTO updatepersonaDTO);
        personaDTO GetPersona(int IdPersona);
        List<personaDTO> GetPersonas();
        personaDTO DeletePersona(int IdPersona);
    }
}
