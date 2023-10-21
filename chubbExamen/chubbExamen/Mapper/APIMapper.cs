using AutoMapper;
using chubbExamen.Models;
using chubbExamen.Models.DTO;

namespace chubbExamen.Mapper
{
    public class APIMapper : Profile
    {
        public APIMapper()
        {

            CreateMap<tbl_Direccion, direccionDTO>().ReverseMap();
            CreateMap<direccionDTO, tbl_Direccion>().ReverseMap();

            CreateMap<tbl_Persona, personaDTO>().ReverseMap();
            CreateMap<personaDTO, tbl_Persona>().ReverseMap();
        }
    }
}
