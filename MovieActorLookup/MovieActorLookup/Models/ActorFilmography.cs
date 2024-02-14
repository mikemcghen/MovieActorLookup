using System.Text.Json.Serialization;

namespace MovieActorLookup.Models
{
    public class ActorFilmography
    {
        [JsonPropertyName("cast")]
        public List<MovieRole> Cast { get; set; }
    }

    public class MovieRole
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("character")]
        public string Character { get; set; }

        [JsonPropertyName("poster_path")]
        public string PosterPath { get; set; }
    }
}
