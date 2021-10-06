using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace EjercicioUDP
{
    public class ClienteUDP
    {
        UdpClient Receptor;
        public event Action<string> Normal, Advert, Alerta;
        

        public void Iniciar()
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 35000);
            Receptor = new UdpClient(ip);

            byte[] buffer = Receptor.Receive(ref ip);

            string mensaje = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
            var Tipo = mensaje.Split('/');

            if (Tipo[1] == "Normal".ToUpper())
            {
                Normal(Tipo[0]);
            }
            else if(Tipo[1] == "Advertencia".ToUpper())
            {
                Advert(Tipo[0]);
            }
            else
            {
                Alerta(Tipo[0]);
            };
        }
    }
}
