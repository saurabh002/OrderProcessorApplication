using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingAPI.Core.Interfaces
{
    public interface INotification
    {
        Task<string> SendNotification(string message);
    }
}
