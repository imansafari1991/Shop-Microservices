using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Messages.Events
{
    public class AddProductEvent:IntegrationBaseEvent
    {
        public int ProductId { get; set; }
        public string ProductTitle { get; set; }
    }
}
