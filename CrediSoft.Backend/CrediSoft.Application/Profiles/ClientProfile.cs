using AutoMapper;
using CrediSoft.Application.DTOs;
using CrediSoft.Domain.Entities;
using CrediSoft.Domain.ValueObjects;

namespace CrediSoft.Application.Profiles
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<Client, ClientDto>();
            CreateMap<CreateClientDto, Client>();
            CreateMap<Client, GetClientDto>();

            CreateMap<UpdateClientDto, Client>()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
