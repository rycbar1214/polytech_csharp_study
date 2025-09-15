namespace DtoMapper.Mapper;

public static class PokemonMapper
{
    public static Models.Pokemon ToModel(this PokemonDto dto)
    {
        // Name과 Types 데이터를 추출하여 Pokemon 모델로 매핑합니다.
        // Types는 List<PokemonTypeDto>에서 각 요소의 이름을 List<string>으로 변환합니다.
        return new Models.Pokemon(
            name: dto.Name ?? "Unknown", 
            types: dto.Types?.Select(t => t.Type?.Name ?? "Unknown").ToList() ?? new List<string>()
        );
    }
}