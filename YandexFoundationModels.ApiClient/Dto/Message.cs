namespace YandexFoundationModels.ApiClient.Dto;

public enum Role
{
    User,
    System,
    Assistant
}

public record Message(
    Role Role,
    string Text);