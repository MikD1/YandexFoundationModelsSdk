namespace YandexFoundationModels.ApiClient.Dto;

public record Usage(
    string InputTextTokens,
    string CompletionTokens,
    string TotalTokens);