using System.ComponentModel.DataAnnotations;

namespace GameStore.Api.Dtos;

// A DTO is a contract between the client and the server since it represents a shared agreement on how data will be used and transferred
public record class CreateGameDto(
    [Required][StringLength(50)] string Name,
    [Required][StringLength(20)] string Genre,
    [Range(1, 100)] decimal Price,
    DateOnly ReleaseDate
);