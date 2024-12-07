namespace YandexFoundationModels.ApiClient.Dto;

public record CompletionRequest(
    string ModelUri,
    CompletionOptions CompletionOptions,
    List<Message> Messages);