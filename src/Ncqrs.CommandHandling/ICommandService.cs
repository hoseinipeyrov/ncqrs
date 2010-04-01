﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ncqrs.Commands;

namespace Ncqrs.CommandHandling
{
    public interface ICommandService
    {
        void Execute(ICommand command);

        void Execute(IEnumerable<ICommand> commands);

        void RegisterHandler<TCommand>(ICommandHandler handler) where TCommand : ICommand;

        void RegisterHandler(Type commandType, ICommandHandler handler);
    }
}