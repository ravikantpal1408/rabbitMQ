using System.Collections.Generic;
using MicroRabbit.Transfer.Application.Dtos;
using MicroRabbit.Transfer.Domain.Models;
using TransferLog = MicroRabbit.Transfer.Domain.Models.TransferLog;


namespace MicroRabbit.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}

