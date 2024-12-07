using Refit;
using YandexFoundationModels.ApiClient.Dto;

namespace YandexFoundationModels.ApiClient;

[Headers("Authorization: Api-Key")]
public interface IOperationApiClient
{
    [Get("/operations/{operationId}")]
    Task<GetOperationResponse> GetOperation(string operationId);
}