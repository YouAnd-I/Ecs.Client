namespace Ecs.Client;

public interface IWorldClient
{
    Task<TResponse> AskAsync<TRequest, TResponse>(
        TRequest request,
        CancellationToken cancellationToken = default);

    IDisposable Subscribe<TNotification>(Func<TNotification, Task> handler);
}
