using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace CleanArch.Domain.Core.Events
{
    public abstract class Message : IRequest<bool>
    {
        public string MessageType { get;protected set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
