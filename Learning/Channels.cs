using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Learning
{
    public class ChannelsExample
    {
        public static async Task DemoChannel()
        {
            var ch = Channel.CreateUnbounded<string>();
            await ch.Writer.WriteAsync("Hello Channel");
            var message = await ch.Reader.ReadAsync();
            Console.WriteLine(message);
        }
    }
}
