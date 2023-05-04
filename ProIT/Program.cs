using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using OpenAI;
using OpenAI.GPT3;
using OpenAI.GPT3.Interfaces;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3.ObjectModels.RequestModels;

namespace ProIT
{
    static class Program
    {
        private static string resp = "";

        static async Task aimain()
        {
            string baseUrl = "http://89.22.107.179:8000/";
            string apiKey = "1R23a2kkOUtRaPYhrVrAMAii6";
            int chatId = 1;
            int userId = 2;

            var ai = new AiApi(baseUrl, apiKey, chatId, userId);
            string messageText = "Hello";

            string response = await ai.SendMessageAsync(messageText);
            Console.WriteLine(response);
            resp = response;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            aimain().Wait();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
