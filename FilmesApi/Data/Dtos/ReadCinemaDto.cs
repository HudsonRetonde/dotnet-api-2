﻿namespace FilmesApi.Data.Dtos
{
	public class ReadCinemaDto
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public ReadEnderecoDto ReadEnderecoDto { get; set; }
	}
}
