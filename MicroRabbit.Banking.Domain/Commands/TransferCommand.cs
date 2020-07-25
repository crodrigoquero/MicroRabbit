using MicroRabbit.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Commands
{
    // this class EXTENDS "Command" abstract class
    public abstract class TransferCommand : Command
    {
        public int From { get; protected set; }
        public int To { get; set; }
        public decimal Amount { get; set; }


    }
}
