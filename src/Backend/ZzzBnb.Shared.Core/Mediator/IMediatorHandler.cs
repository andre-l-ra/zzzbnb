using ZzzBnb.Shared.Core.Messages;
using ZzzBnb.Shared.Core.Validation;

namespace ZzzBnb.Shared.Core.Mediator;

public interface IMediatorHandler
{
 Task<ValidationResult> SendCommand<T>(T command) where T : Command;   
}