using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackAPI
{
	[RequestPath("rtm.connect")]
	public class LoginResponse : Response
	{
		public Self self;
		public Team team;
		public string url;
	}

    public class Self
    {
        public DateTime created;
        public string id;
        public string manual_presence;
        public string name;
        public Preferences prefs;
    }
}
