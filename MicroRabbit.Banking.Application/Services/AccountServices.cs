using System.Collections.Generic;
using MicroRabbit.Banking.Application.Dtos;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountServices : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _bus;

        public AccountServices(IAccountRepository accountRepository, IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransferDto accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                    accountTransfer.FromAccount,
                    accountTransfer.ToAccount,
                    accountTransfer.TransferAmount
                );

            _bus.SendCommand(createTransferCommand);
        }
    }
}