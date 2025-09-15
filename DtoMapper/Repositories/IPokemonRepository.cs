namespace DtoMapper.Repositories;

public interface IPokemonRepository
{
    Task<Models.Pokemon?> GetPokemonByNameAsync(string pokemonName);
}