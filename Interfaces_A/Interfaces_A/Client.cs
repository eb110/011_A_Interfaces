using Interfaces_A.inerfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_A
{
    public class Client
    {
        private I_Communication communication;

        public void SaveClient()
        {
            communication.Connect("abcdef");
        }
    }
}
