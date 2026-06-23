namespace ZzzBnb.Shared.Core.Messaging;

  public interface ICommandDispatcher
  {
      Task<TResult> SendAsync<TCommand, TResult>(TCommand command, CancellationToken cancellationToken = default);
  }