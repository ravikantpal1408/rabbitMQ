namespace MicroRabbit.Transfer.Application.Dtos
{
    public abstract class TransferLog
    {
        public int Id { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAccount { get; set; }
    }
}