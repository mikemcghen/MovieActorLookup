using System.Text.Json.Serialization;

namespace MovieActorLookup.Models
{
    public class Actor
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("cast")]
        public List<MovieCharacter> MovieCharacters { get; set; } = new List<MovieCharacter>();

        public Actor(string name)
        {
            Name = name;
        }
    }

    public class MovieCharacter
    {
        [JsonPropertyName("title")]
        public string MovieTitle { get; set; }

        [JsonPropertyName("character")]
        public string CharacterName { get; set; }

        [JsonPropertyName("poster_path")]
        public string MoviePosterPath { get; set; }

        [JsonPropertyName("overview")]
        public string Overview { get; set; }

        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; }
    }
}
