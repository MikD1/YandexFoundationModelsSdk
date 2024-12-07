using YandexFoundationModels.ApiClient;
using YandexFoundationModels.ApiClient.Dto;

const string folderId = "";
const string apiKey = "";

const string modelUri = $"gpt://{folderId}/{YandexGptModels.YandexGptLatest}";
const string prompt =
    "Я тестирую свою программу, которая вызывает API YandexGPT. Если все работает, ответь 'Все работает в асинхронном режиме!' и напиши случайное животное.";
CompletionRequest request = new(modelUri, new(false, 0.9f, "2000"), [new(Role.User, prompt)]);

try
{
    ILlmApiClient llmApiClient = ApiClientsFactory.CreateLlmApiClient(apiKey);
    IOperationApiClient operationApiClient = ApiClientsFactory.CreateOperationApiClient(apiKey);
    GetOperationResponse response = await llmApiClient.CompletionAsync(request);
    string operationId = response.Id;
    int counter = 0;
    while (!response.Done)
    {
        response = await operationApiClient.GetOperation(operationId);
        await Task.Delay(500);
        ++counter;
    }

    Console.WriteLine(response.Response?.Alternatives.Single().Message.Text);
    Console.WriteLine($"Counter: {counter}");
}
catch (Exception e)
{
    Console.WriteLine(e);
}