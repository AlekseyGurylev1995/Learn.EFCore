using System.Threading.Tasks;

using Learn.EFCore.Application.Abstractions;

namespace Learn.EFCore.Application.UseCases.Player.Commands.CreateAccountByLogin
{
    internal sealed class CreateAccountByLoginHandler : ICommandHandler<CreateAccountByLoginCommand>
    {
        private readonly IAccountRepository _accountRepository;

        public CreateAccountByLoginHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task HandleAsync(CreateAccountByLoginCommand command)
        {
            await _accountRepository.CreateByLoginAsync(
                command.Login,
                command.Password);

            // если ошибка, на уровне имплиментации репозитория выкидываем ошибку
            // далее просто пойдёт на уровень API, там зафиксируется для текущего запроса

            // что завтра требуется
            //  решить пару задачек по SQL
            //  составить архитектуру таблиц + SQL скрипты для реализации
            //  всё это оформить визуально, расставить связи 1к1 1кМ
        }
    }
}
