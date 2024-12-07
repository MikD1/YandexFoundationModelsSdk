namespace YandexFoundationModels.ApiClient.Dto;

public record Result(
    List<Alternative> Alternatives,
    Usage Usage,
    string ModelVersion);