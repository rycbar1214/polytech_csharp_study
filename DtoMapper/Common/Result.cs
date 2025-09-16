namespace DtoMapper.Common;

public abstract record Result<TData, TError>
{
    public sealed record Success(TData Data): Result<TData, TError>;
    
    public sealed record Error(TData error): Result<TData, TError>;
}