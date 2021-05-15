using Interfaces_A.inerfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_A
{
    class MysqlCommunication : I_Communication
    {
        public string username { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Connect(string connectionString)
        {
            throw new NotImplementedException();
        }
    }
}
