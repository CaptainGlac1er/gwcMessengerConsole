using gwcWebProjectLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gwcMessengerConsole
{
    class Messenger : gwcDataTransfer
    {
        Connection connection;
        public Messenger()
        {
        }
        public void setup(Connection connection)
        {
            while (true) {
                Console.WriteLine("0 for listen 1 for connect to");
                String input = Console.ReadLine();
                if (input.Equals("0"))
                {
                    Console.WriteLine("what port");
                    connection.listen(Int32.Parse(Console.ReadLine()));
                    break;
                }
                else if (input.Equals("1"))
                {
                    Console.WriteLine("what address");
                    string addess = Console.ReadLine();
                    Console.WriteLine("what port");
                    connection.start(addess, Int32.Parse(Console.ReadLine()));
                    break;
                }
                    
            }
            this.connection = connection;

        }
        public void communicate()
        {
            while (true)
            {
                connection.queueToSend(Encoding.UTF8.GetBytes(Console.ReadLine()));
            }
        }

        public void update(byte[] data)
        {
            Console.WriteLine("Recieved \"" + Encoding.UTF8.GetString(data).Trim(new char[]{ (char)0 }) + "\"");
        }
    }
}
