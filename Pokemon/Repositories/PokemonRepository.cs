using Pokemon.DataSource;

namespace Pokemon.Repositories;

public class PokemonRepository : IPokemonRepository
{
    private IPokemonApiDataSource _dataSource;

    public PokemonRepository(IPokemonApiDataSource dataSource)
    {
        _dataSource = dataSource;
    }

    public async Task<Pokemon?> GetPokemonByNameAsync(string pokemonName)
    {
        try
        {
            var response = await _dataSource.GetPokemonAsync(pokemonName);
            return response.Body;
        }
        catch (Exception e)
        {
            return null;
        }
    }
}