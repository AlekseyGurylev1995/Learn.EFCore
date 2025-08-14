using System.Threading.Tasks;

namespace Learn.EFCore.Application.Abstractions;

internal interface ICommandHandler<TCommand>
{
    Task HandleAsync(TCommand command);
}

