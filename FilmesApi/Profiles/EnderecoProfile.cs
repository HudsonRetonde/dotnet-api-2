using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profiles
{
	public class EnderecoProfile : Profile
	{
		public EnderecoProfile()
		{
			CreateMap<CreateEnderecoDto, Endereco>();
			CreateMap<ReadEnderecoDto, Endereco>();
			CreateMap<UpdateEnderecoDto, Endereco>();
		}
	}
}
