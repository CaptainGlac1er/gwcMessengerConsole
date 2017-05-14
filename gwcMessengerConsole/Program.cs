using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gwcWebProjectLibrary;

namespace gwcMessengerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Messenger messenger = new Messenger();
            Connection connection = new Connection(messenger);
            messenger.setup(connection);
            messenger.communicate();
        }
    }
}
