using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CleanArch.Domain.Core.Commands;

namespace CleanArch.Domain.Core.Bus
{
    public interface IMediatRHandler
    {
        Task SendCommand<T>(T command) where T : Command;
    }
}
