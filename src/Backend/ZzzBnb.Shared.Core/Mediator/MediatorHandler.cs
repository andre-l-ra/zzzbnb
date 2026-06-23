namespace ZzzBnb.Shared.Core.Mediator;

  public class MediatorHandler
  {
          public async Task<ValidationResult> SendCommand<T>(T command) where T : Command
    {
        return await commandDispatcher.SendAsync<T, ValidationResult>(command);
    }
  }