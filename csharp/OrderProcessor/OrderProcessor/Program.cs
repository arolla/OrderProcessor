// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic; 
using OrderProcessor;


OrderProcessor.OrderProcessor processor = new OrderProcessor.OrderProcessor();
processor.ProcessOrder("VIP123", new List<string> { "BOOK", "DVD" }, "CREDIT", "EXPRESS");