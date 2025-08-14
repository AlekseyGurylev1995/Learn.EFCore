namespace Learn.EFCore.Application.UseCases.Commands.CreateAccountByLogin;

public class CreateAccountByLoginCommand
{
    public Parameters.Login Login { get; }

    public Parameters.Password Password { get; }
}

