using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class CancionMongo
{
    [BsonId]
    public ObjectId Id { get; set; }  // El identificador único de la canción en MongoDB
    
    public string Titulo { get; set; }
    public string Album { get; set; }
    public int Año { get; set; }
    public double Duracion { get; set; }  // La duración en minutos
    public string Genero { get; set; }
    public string Compositor { get; set; }
    public int Popularidad { get; set; }
    public int ViewsSpotify { get; set; }
}