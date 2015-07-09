using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace OWINSignalR
{

    using Microsoft.AspNet.SignalR.Hubs;

    [HubName("bugsHub")]
    public class BugsHub : Hub
    {

        public void OgChart(string chartname){
            Clients.All.RecMessage(chartname);
        }
    }
}