using YandexFoundationModels.ApiClient;
using YandexFoundationModels.ApiClient.Dto;

const string folderId = "";
const string apiKey = "";

const string modelUri = $"gpt://{folderId}/{YandexGptModels.YandexGptLatest}";
const string prompt =
    "Я тестирую свою программу, которая вызывает API YandexGPT. Если все работает, ответь 'Все работает!' и напиши случайный цвет.";
CompletionRequest request = new(modelUri, new(false, 0.9f, "2000"), [new(Role.User, prompt)]);

try
{
    ILlmApiClient client = ApiClientsFactory.CreateLlmApiClient(apiKey);
    CompletionResponse response = await client.Completion(request);
    Console.WriteLine(response.Result.Alternatives.Single().Message.Text);
}
catch (Exception e)
{
    Console.WriteLine(e);
}