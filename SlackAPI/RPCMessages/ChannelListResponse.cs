using System;

namespace SlackAPI
{
    [RequestPath("conversations.list")]
    public class ChannelListResponse : Response
    {
        public Channel[] channels;
    }
}
