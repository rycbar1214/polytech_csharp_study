namespace DtoMapper.DataSource;

public interface IPokemonApiDataSource
{
    Task<Response<Pokemon>> GetPokemonAsync(string pokemonName);
}