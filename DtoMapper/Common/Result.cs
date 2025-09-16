using DtoMapper.Repositories;

namespace DtoMapper.Common;

public abstract record Result<TData, TError>
{
    public sealed record Success(TData Data): Result<TData, TError>;
    
    public sealed record Error(PokemonError error): Result<TData, TError>;
}