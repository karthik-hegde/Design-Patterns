using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public abstract class Device
    {
        protected IMediator _mediator;

        public void setMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}