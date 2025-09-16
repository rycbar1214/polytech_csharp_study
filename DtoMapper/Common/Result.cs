using DtoMapper.Models;

namespace DtoMapper.Common;

public enum PokemonError
{
    NetworkTimeout,
    NotFound,
    Unknown,
    AuthenticationFailed,
    NetworkError,
    InvalidInput,
    UnknownError
}

public record Result<TData, TError>
{
    public Result()
    {
        
    }
    public sealed record Success(TData Data): Result<TData, TError>
    {
        public Pokemon data;
    }

    public sealed record Error(TError error): Result<TData, TError>;
};