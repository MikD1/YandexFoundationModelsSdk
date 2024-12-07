namespace YandexFoundationModels.ApiClient.Dto;

public record CompletionOptions(
    bool Stream,
    float Temperature,
    string MaxTokens);