using SlackAPI;
using System;

string SLACK_TOKEN = Environment.GetEnvironmentVariable("SLACK_TOKEN") ?? "";

SlackSocketClient client = new SlackSocketClient(SLACK_TOKEN);
client.Connect((response) => Console.WriteLine(response.ok));

// List<Channel> channels = new List<Channel>();
// client.GetChannelList((response) => channels = response.channels.ToList());
// Console.WriteLine(channels.Count);
while (true)
{
    string? input = Console.ReadLine();
    byte[] fileData = System.IO.File.ReadAllBytes("./tmp/gnome-child.png");
    client.UploadFile((response) => Console.WriteLine(response.file.permalink), fileData, "gnome-child.png", ["C05FFHVD37Z"], "Gnome Child", "A gnome child image");
}
