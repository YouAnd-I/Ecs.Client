namespace Ecs.Client;

/// <summary>
/// The only door into the world. Adapters (Discord, Telegram, MCP, ...) put plain data in
/// and get plain data back; they never see the ECS behind this interface.
/// </summary>
public interface IWorldClient
{
    /// <summary>
    /// Sends <paramref name="request"/> into the world and waits until a system answers it
    /// with a <typeparamref name="TResponse"/>. Safe to call from any thread.
    /// </summary>
    Task<TResponse> AskAsync<TRequest, TResponse>(
        TRequest request,
        CancellationToken cancellationToken = default);
}
