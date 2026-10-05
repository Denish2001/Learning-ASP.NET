namespace GameStore.Api.Dtos;

// A DTO is a contract between the client and the server since it represents a shared agreement on how data will be used and transferred
public record class GameDto(
    int Id,
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate

);