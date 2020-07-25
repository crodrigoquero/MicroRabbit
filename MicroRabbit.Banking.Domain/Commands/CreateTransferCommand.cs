using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Commands
{
    // THIS CLASS EXTENDENDS "TransferCommand" CLASS
    // we are implementing a comunication protocol (with RabbitMQ)
    // so, its a good idea to use ABSTRACT CLASSES in order assure CONSISTENCY in PROTOCOL STRUCTURE
    // and IMPLEMENTATION. "TransferCommand" is an abstract class
    public class CreateTransferCommand : TransferCommand
    {
        public CreateTransferCommand(int from , int to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }


    }
}
