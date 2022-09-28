using SlackAPI;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

SlackSocketClient client = new SlackSocketClient("xoxb-15587958630-551525529541-mtBRI8KTYxYkiFyA3rWAWP3C");
client.Connect((response) => Console.WriteLine(response.ok));

List<Channel> channels = new List<Channel>();

//client.GetChannelList((response) => Console.WriteLine(response.channels));

while (true)
{
    var y = Console.ReadLine();
    client.GetChannelList((response) => channels = response.channels.ToList());
    Console.WriteLine(channels.Count);
}