using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace BookStoreApi.Models;

public class Book
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("Name")]
    [JsonPropertyName("Name")]
    public string BookName { get; set; } = null!;

    [JsonPropertyName("Price")]
    public decimal Price { get; set; }

    [JsonPropertyName("Category")]
    public string Category { get; set; } = null!;

    [JsonPropertyName("Author")]
    public string Author { get; set; } = null!;
}