using ZzzBnb.Shared.Core.Messages;

namespace ZzzBnb.Shared.Core.Messaging;

public interface ICommandHandler<in TCommand, TResult> where TCommand : Command
{
    Task<TResult> Handle(TCommand command, CancellationToken cancellationToken = default);
}
