using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OWINSignalR.Startup1))]

namespace OWINSignalR
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app) { app.MapSignalR(); }
    }
}
