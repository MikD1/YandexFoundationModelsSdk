namespace YandexFoundationModels.ApiClient.Dto;

public record GetOperationResponse(
    string Id,
    string Description,
    string CreatedAt,
    string CreatedBy,
    string ModifiedAt,
    bool Done,
    Error? Error,
    Result? Response);