using System.Collections.Generic;
using MicroRabbit.Banking.Application.Dtos;
using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransferDto accountTransfer);
    }
}