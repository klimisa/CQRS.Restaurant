using System;
using CQRSlite.Commands;

namespace CQRS.Restaurant.Contracts
{
    public class BaseCommand: ICommand
    {
        public Guid Id { get; set; }
        public int ExpectedVersion { get; set; }
    }
}
