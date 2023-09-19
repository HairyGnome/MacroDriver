using Octokit;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MacroDriver
{
    class UpdateHandler
    {
        public static string version = "v0.3.1";

        public async void CheckForUpdates()
        {
            try
            {
                GitHubClient client = new GitHubClient(new ProductHeaderValue("MacroDriver"));
                var release = await client.Repository.Release.GetAll("HairyGnome", "MacroDriver");
                var latest = release[0];
                if (string.Compare(version, latest.Name) < 0)
                {
                    WebClient webClient = new WebClient();
                    webClient.Headers.Add("user-agent", "Anything");
                    webClient.Headers.Add("authorization", "token " + GitHubToken.Token);
                    await webClient.DownloadFileTaskAsync(new Uri(latest.ZipballUrl), $"MacroDriver {version}");
                }
            }
            catch(Octokit.NotFoundException)
            {
                TBConsole.WriteLine("Could not find update information.");
            }

        }
    }
}
