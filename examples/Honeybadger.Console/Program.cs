﻿// See https://aka.ms/new-console-template for more information

using Honeybadger;

Console.WriteLine("Hello, World!");

var client = HoneybadgerSdk.Init(new HoneybadgerOptions
{
    AppEnvironment = "development"
});

client.Notify("hello from .Net !");

Thread.Sleep(1000);