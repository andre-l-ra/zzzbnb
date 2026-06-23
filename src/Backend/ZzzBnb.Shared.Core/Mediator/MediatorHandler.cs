using ZzzBnb.Shared.Core.Messages;
using ZzzBnb.Shared.Core.Messaging;
using ZzzBnb.Shared.Core.Validation;

namespace ZzzBnb.Shared.Core.Mediator;

public class MediatorHandler(ICommandDispatcher commandDispatcher) : IMediatorHandler
{
    public async Task<ValidationResult> SendCommand<T>(T command) where T : Command
    {
        return await commandDispatcher.SendAsync<T, ValidationResult>(command);
    }
}
