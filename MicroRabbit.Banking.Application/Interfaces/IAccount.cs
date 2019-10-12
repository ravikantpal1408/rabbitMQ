using System.Collections.Generic;
using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Application.Interfaces
{
    public interface IAccount
    {
        IEnumerable<Account> GetAccounts();
    }
}