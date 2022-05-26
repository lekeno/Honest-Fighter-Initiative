using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HonestFighterInitiative
{
    internal class PingService
    {
        internal async Task<PingReply> PingTo(string ip, int timeout = 1000)
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send(ip, timeout);

                return reply;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }

            return null;
        }
    }
}
