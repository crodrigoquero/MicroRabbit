using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Domain.Models
{
    public class TransferLog
    {
        public int Id { get; set; }
        public int FromAccount { get; set; }
        public decimal ToAccount { get; set; }
        public decimal  TransferAmmount { get; set; }

    }
}
