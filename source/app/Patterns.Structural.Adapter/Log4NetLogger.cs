// --------------------------------------------------------------------------------
// Copyright © IcamSystems GmbH, 2015
// Erstellt am: 25.12.2015 07:12
// Autor: André Harms
// --------------------------------------------------------------------------------

using System;

namespace Patterns.Structural.Adapter
{
    public class Log4NetLogger
    {
        public void Log(string type, string messsag)
        {
            Console.WriteLine("type:{0} message: {1}", type, messsag);
        } 
    }
}