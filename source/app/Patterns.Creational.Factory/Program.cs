using System;
using System.Collections.Generic;

using Patterns.Core.Models;

namespace Patterns.Creational.Factory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            do
            {
                var creators = new List<DocumentCreatorBase>
                {
                   DeliveryNoteCreator.Factory
                    , new InvoiceCreator(InvoiceType.PartialPayment)
                    , new InvoiceCreator(InvoiceType.Performa)
                };
                

                foreach (var creator in creators)
                {
                    try
                    {
                        creator.Validate();
                    }
                    catch (InvalidOperationException exception)
                    {
                        
                       Console.WriteLine(exception.Message);
                    }
                }
            }
            while (Console.ReadLine() != "C");

        }
    }
}