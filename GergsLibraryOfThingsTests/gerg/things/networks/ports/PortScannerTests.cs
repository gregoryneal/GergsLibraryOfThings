using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Sockets;
using System.Net;

//Tests dont pass unless you grant this program firewall access (I think, not too familiar with network programming)
//TODO: Add tests for a range of ports
namespace GergsLibraryOfThings.gerg.things.networks.ports.Tests
{
    [TestClass()]
    public class PortScannerTests
    {
        private int minPort = 45594;
        private TcpListener listener;
        private static string ipStr = "127.0.0.1";

        [TestMethod()]
        public void ScanForOpenPortsTest()
        {
            //Arrange
            IPAddress IP = IPAddress.Parse(ipStr);

            listener = new TcpListener(IP, minPort);
            listener.Start();

            PortScanner ps = new PortScanner(IP, minPort);

            //Act
            ps.ScanForOpenPorts();
            listener.Stop();

            //Assert
            Assert.AreEqual(ps.GetOpenPorts()[0], minPort);
        }
    }
}