using System.Threading.Tasks;

using Learn.EFCore.Application.Abstractions;
using Learn.EFCore.Application.Abstractions.Repositories;
using Learn.EFCore.Core.Abstractions;
using Learn.EFCore.Core.Enums;
using Learn.EFCore.Core.VObjects;

namespace Learn.EFCore.Application.UseCases.Player.Commands.CreateAccountByLogin
{
    internal sealed class CreateAccountByLoginHandler : ICommandHandler<CreateAccountByLoginCommand>
    {
        private readonly IAuthDataByLoginRepository _authDataByLoginRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly IPasswordHasher _passwordHasher;

        public CreateAccountByLoginHandler(
            IAuthDataByLoginRepository authDataByLoginRepository,
            IAccountRepository accountRepository,
            IPasswordHasher passwordHasher)
        {
            _authDataByLoginRepository = authDataByLoginRepository;
            _accountRepository = accountRepository;
            _passwordHasher = passwordHasher;
        }

        public async Task HandleAsync(CreateAccountByLoginCommand command)
        {
            // тип алгоритма хэширования брать из глобальных настроек
            var passwordHash = _passwordHasher.Hash(
                command.Password,
                PasswordHash.HashAlgorithmType.Simple);

            // здесь нужно открыть бизнес транзакцию

            var accountId = await _accountRepository.CreateAsync(AccountState.Unconfirmed);

            _authDataByLoginRepository.CreateAsync(
                command.Login,
                accountId,
                passwordHash);

            // здесь нужно закоммитить транзакцию,
            // если внутри блока транзакции что-то произошло то откатить транзакцию
        }
    }
}
