using Refit;

namespace YandexFoundationModels.ApiClient;

public static class ApiClientsFactory
{
    public static ILlmApiClient CreateLlmApiClient(string apiKey)
    {
        const string baseUrl = "https://llm.api.cloud.yandex.net";
        return CreateRestService<ILlmApiClient>(baseUrl, apiKey);
    }

    public static IOperationApiClient CreateOperationApiClient(string apiKey)
    {
        const string baseUrl = "https://operation.api.cloud.yandex.net";
        return CreateRestService<IOperationApiClient>(baseUrl, apiKey);
    }

    private static T CreateRestService<T>(string baseUrl, string apiKey)
    {
        RefitSettings settings = new()
        {
            AuthorizationHeaderValueGetter = (_, _) => Task.FromResult(apiKey)
        };

        return RestService.For<T>(baseUrl, settings);
    }
}