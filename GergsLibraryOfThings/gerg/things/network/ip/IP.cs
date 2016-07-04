namespace GergsLibraryOfThings.gerg.things.network.ip
{
    public class IP
    {
        private IPType ipType;
        private uint ipv4ip;


        public IP(uint ipv4) {
            this.ipv4ip = ipv4;
            this.ipType = IPType.IPv4;
        }

        private void Validate() {

        }
    }
}
