using AutoMapper;
using ApiVendas.Domain.Models;
using ApiVendas.WebApi.Dtos;

namespace ApiVendas.WebApi
{
    public class WebApiMapperProfile : Profile
    {
        public WebApiMapperProfile()
        {
            CreateMap<Filme, FilmesGetResult>();
            CreateMap<FilmesGet, Pesquisa>();

            CreateMap<VendaPost, Venda>();
            CreateMap<Venda, VendaPost>();
        }
    }
}
