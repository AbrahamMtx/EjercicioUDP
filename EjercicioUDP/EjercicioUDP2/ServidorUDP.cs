using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace EjercicioUDP2
{
    public class ServidorUDP
    {
        UdpClient servidor = new UdpClient() { EnableBroadcast = true};

        public void Enviar(string Mensaje, string tipo)
        {
            string datos = $"{Mensaje}/{tipo}";
            byte[] buffer = Encoding.UTF8.GetBytes(datos);

            servidor.Send(buffer, buffer.Length, new IPEndPoint(IPAddress.Broadcast, 35000));
        }
    }
}
