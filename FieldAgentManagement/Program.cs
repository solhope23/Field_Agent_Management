using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldAgentManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            agent dd = new agent("dd", "bb", "ff", "Active", 2);
            AgentDAL ss = new AgentDAL("localhost", "rצךחoot", "eagleeyedb");
            ss.AddAgent(dd);

        }
    }
}
