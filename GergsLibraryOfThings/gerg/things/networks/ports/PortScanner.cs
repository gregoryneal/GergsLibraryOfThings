using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace GergsLibraryOfThings.gerg.things.networks.ports
{
    public class PortScanner
    {
        private List<int> openPorts = new List<int>();
        private IPAddress ipAddress;
        private int[] portRange = new int[2];

        public PortScanner(IPAddress address, int port) {
            ipAddress = address;
            portRange[0] = portRange[1] = port;
        }

        public PortScanner(string address, int port) {
            if(!IPAddress.TryParse(address, out ipAddress)) {
                //Error
            }
            else {
                portRange[0] = portRange[1] = port;
            }
        }

        public PortScanner(string address, int minPort, int maxPort) {
            if(!IPAddress.TryParse(address, out ipAddress)) {
                //Error
            }
            else {
                portRange[0] = minPort;
                portRange[1] = maxPort;
            }
        }

        public void ScanForOpenPorts(bool printResults = false) {
            TcpClient tcpClient = new TcpClient();
            for(int i = portRange[0]; i <= portRange[1]; i++) {
                try {
                    tcpClient.Connect(ipAddress, i);
                    openPorts.Add(i);

                    if (printResults) {
                        Console.WriteLine(i + " - OPEN");
                    }

                } catch (Exception) {

                    if (printResults) {
                        Console.WriteLine(i + " - CLOSED");
                    }

                }
            }
        }

        public List<int> GetOpenPorts() {
            return openPorts;
        }

        public void PrintOpenPorts() {
            foreach(int openPort in this.openPorts) {
                Console.WriteLine(openPort + " - OPEN");
            }
        }
    }
}
