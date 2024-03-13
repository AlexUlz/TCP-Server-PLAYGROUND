using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Server_PLAYGROUND
{
    class PacketBuilder
    {

        MemoryStream ms;
        public PacketBuilder() { ms = new MemoryStream(); }

        public void WriteOpCode(byte opcode) //Operation Code ist eine Reihe von Zahlen, die einen Befehlsatzt bilden. 
        {
            ms.WriteByte(opcode);
        }

        public void WriteString(string msg) 
        { 
            ms.Write(BitConverter.GetBytes(msg.Length));
            ms.Write(Encoding.ASCII.GetBytes(msg));
        }

        public byte[] GetPacketBytes() { return ms.ToArray(); }
    }
}
