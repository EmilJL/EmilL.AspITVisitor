﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmilLAspITVisitor.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server(9999);
            server.Start();
        }
    }
}
