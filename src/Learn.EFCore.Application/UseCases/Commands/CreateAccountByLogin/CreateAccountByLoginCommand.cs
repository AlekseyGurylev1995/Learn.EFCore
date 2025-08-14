using Learn.EFCore.Core.VObjects;

namespace Learn.EFCore.Application.UseCases.Commands.CreateAccountByLogin;

public sealed class CreateAccountByLoginCommand
{
    public Login Login { get; }

    public Password Password { get; }
}

