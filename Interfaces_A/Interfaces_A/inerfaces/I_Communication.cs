using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_A.inerfaces
{
    public interface I_Communication
    {
        string username { get; set; }
        bool Connect(string connectionString);
    }
}
