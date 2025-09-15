using Newtonsoft.Json;

namespace DtoMapper.Models;

public class Pokemon
{
    public string Name { get; set; }
    public string sprites {get; set;}
    
}

public class Sprites
{
    public Other other { get; set; }
}

public class Other
{
    [JsonProperty("official-artwork")]
    public OfficialArtwork OfficialArtwork {get; set;}
}

/*public class PokemonSprites
{
    [JsonProperty("front_default")]
    public string? OfficialArtworkUrl {get; set;}
}

public class OtherSprites
{
    [JsonProperty("official-artwork")]
    public PokemonSprites? OfficialArtwork {get; set;}
}

public class Pokemon
{
    [JsonProperty("name")]
    public string? Name {get; set;}

    [JsonProperty("sprites")]
    public OtherSprites? Sprites {get; set;}
}*/