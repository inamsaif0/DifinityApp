﻿// using Microsoft.AspNetCore.Components;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Dfinity.Blazor.SampleApp.Pages
// {
//     public partial class Index
//     {
//         [Inject]
//         public DfinityService DfinityService { get; set; } = default!;

//         public string Output { get; set; } = "Output:";

//         public async Task Test()
//         {
//             await DfinityService.Test();
//             WriteOutput($"Test");

//         }

//         public async Task WriteData()
//         {
//             WriteOutput("Writing data to IC...");
//             string value = DateTimeOffset.UtcNow.ToString();
//             await DfinityService.SetValue("time", value);
//             WriteOutput($"Written value: {value}");
//         }

        
//         public async Task GetData()
//         {
//             WriteOutput("Getting data from IC...");
//             string? value = await DfinityService.GetValue("time");
//             Console.WriteLine("Value: " + value);
//             WriteOutput($"Get value: {value}");

//         }


//         public async Task IsLoggedIn()
//         {
//             bool isLoggedIn = await DfinityService.IsLoggedIn();
//             Console.WriteLine("Logged in: " + isLoggedIn);
//             WriteOutput($"Logged in: {isLoggedIn}");

//         }

//         public async Task Login()
//         {
//             await DfinityService.Login();
//             WriteOutput($"Opend logged in window");

//         }

//         public async Task Logout()
//         {
//             await DfinityService.Logout();
//             WriteOutput($"Loggout");

//         }

//         public async Task WriteDataForUser()
//         {
//             if (!(await DfinityService.IsLoggedIn()))
//                 WriteOutput("WARNING: this will fail, user is not logged in.");

//             string value = DateTimeOffset.UtcNow.ToString();
           
//             WriteOutput("Writing data to IC...");
//             await DfinityService.SetValueForUser("time", value);
//             WriteOutput($"Write value for current user: {value}");

//         }
//         public async Task GetDataForUser()
//         {
//             if (!(await DfinityService.IsLoggedIn()))
//                 WriteOutput("WARNING: this will fail, user is not logged in.");

//             WriteOutput("Getting data from IC...");
//             var value = await DfinityService.GetValueForUser("time");
//             Console.WriteLine("Uservalue: " + value);
//             WriteOutput($"Get value for current user: {value}");


//         }


//         private void WriteOutput(string text)
//         {
//             Output += "\r\n" + text;
//         }

//     }
// }

using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace Dfinity.Blazor.SampleApp.Pages
{
    public partial class Index
    {
        // Inject the DfinityService
        [Inject]
        public DfinityService DfinityService { get; set; } = default!;

        // Output to display messages
        public string Output { get; set; } = "Output:";

        // Handle Test button click
        public async Task Test()
        {
            await DfinityService.Test();
            WriteOutput("Test");
        }

        // Handle Write Data button click
        public async Task WriteData()
        {
            WriteOutput("Writing data to IC...");
            string value = DateTimeOffset.UtcNow.ToString();
            await DfinityService.SetValue("time", value);
            WriteOutput($"Written value: {value}");
        }

        // Handle Get Data button click
        public async Task GetData()
        {
            WriteOutput("Getting data from IC...");
            string? value = await DfinityService.GetValue("time");
            Console.WriteLine("Value: " + value);
            WriteOutput($"Get value: {value}");
        }

        // Handle Is Logged In button click
        public async Task IsLoggedIn()
        {
            bool isLoggedIn = await DfinityService.IsLoggedIn();
            Console.WriteLine("Logged in: " + isLoggedIn);
            WriteOutput($"Logged in: {isLoggedIn}");
        }

        // Handle Login button click
        public async Task Login()
        {
            await DfinityService.Login();
            WriteOutput($"Opened logged in window");
        }

        // Handle Logout button click
        public async Task Logout()
        {
            await DfinityService.Logout();
            WriteOutput($"Logout");
        }

        // Handle Write Data For User button click
        public async Task WriteDataForUser()
        {
            if (!(await DfinityService.IsLoggedIn()))
            {
                WriteOutput("WARNING: This will fail, user is not logged in.");
                return;
            }

            string value = DateTimeOffset.UtcNow.ToString();
            WriteOutput("Writing data to IC...");
            await DfinityService.SetValueForUser("time", value);
            WriteOutput($"Write value for current user: {value}");
        }

        // Handle Get Data For User button click
        public async Task GetDataForUser()
        {
            if (!(await DfinityService.IsLoggedIn()))
            {
                WriteOutput("WARNING: This will fail, user is not logged in.");
                return;
            }

            WriteOutput("Getting data from IC...");
            var value = await DfinityService.GetValueForUser("time");
            Console.WriteLine("User value: " + value);
            WriteOutput($"Get value for current user: {value}");
        }

        // Helper method to update the output text
        private void WriteOutput(string text)
        {
            Output += "\r\n" + text;
        }
    }
}

