﻿using System;
using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Flatware;
using BlazorStandaloneLib;

namespace BlazorStandalone
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(configure =>
            {
                configure.AddFlatware<MyMsg, MyMdl>(MyMdl.Init);
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}
