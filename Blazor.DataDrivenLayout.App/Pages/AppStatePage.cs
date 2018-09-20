using Microsoft.AspNetCore.Blazor.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.DataDrivenLayout.App.Pages
{
    public class AppStatePage : BlazorComponent
    {
        public AppState appState { get; set; } 

        public AppStatePage()
        {
            appState = new AppState();
        }
    }
}
