using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OrderProcessingAPI.Core.Interfaces;

namespace OrderProcecssingAPI.Business
{
   public class EmailNotification: INotification
    {
        public Task<string> SendNotification(string message)
        {
            return Task.FromResult(message);
        }
    }
}
