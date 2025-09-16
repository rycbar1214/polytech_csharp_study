using DtoMapper.Common;

namespace DtoMapper.Repositories;

public interface IPokemonRepository
{
    Task<Result<Models.Pokemon, PokemonError>> GetPokemonByNameAsync(string pokemonName);
}