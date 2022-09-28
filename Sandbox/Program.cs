using SlackAPI;

SlackSocketClient client = new SlackSocketClient("xoxb-15587958630-551525529541-mtBRI8KTYxYkiFyA3rWAWP3C");
client.Connect((response) => Console.WriteLine(response.ok));

List<Channel> channels = new List<Channel>();

while (true)
{
    string? input = Console.ReadLine();
    client.GetChannelList((response) => channels = response.channels.ToList());
    Console.WriteLine(channels.Count);
}