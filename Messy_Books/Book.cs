using System;
using System.Text.Json.Serialization;

namespace Task4
{
    public class Book
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("publication_year")]
    public int PublicationYear { get; set; }

    [JsonPropertyName("author")]
    public string Author { get; set; } = string.Empty;

    [JsonPropertyName("isbn")]
    public string Isbn { get; set; } = string.Empty;
}
}
