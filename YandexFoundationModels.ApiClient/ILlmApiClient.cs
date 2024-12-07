using Refit;
using YandexFoundationModels.ApiClient.Dto;

namespace YandexFoundationModels.ApiClient;

[Headers("Authorization: Api-Key")]
public interface ILlmApiClient
{
    [Post("/foundationModels/v1/completion")]
    Task<CompletionResponse> Completion([Body] CompletionRequest request);

    [Post("/foundationModels/v1/completionAsync")]
    Task<GetOperationResponse> CompletionAsync([Body] CompletionRequest request);
}