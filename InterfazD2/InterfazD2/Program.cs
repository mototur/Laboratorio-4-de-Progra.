using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazD2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                NotificaciondeEmail correoNotificacion = new NotificaciondeEmail("LuuSandoval72@gmail.com");
                NotificaciondeWhatsap whatsappNotificacion = new NotificaciondeWhatsap("+502 59398318");
                NotificaciondeTelefono mensajeNotificacion = new NotificaciondeTelefono("+502 40032369");

                correoNotificacion.Notificacion();
                whatsappNotificacion.Notificacion();
                mensajeNotificacion.Notificacion();
                Console.Read();
            }
        }
        public interface INotificable
        {
            void Notificacion();
        }

        public class NotificaciondeEmail : INotificable
        {
            private string CorreoElectronico;

            public NotificaciondeEmail(string direccionCorreo)
            {
                this.CorreoElectronico = direccionCorreo;
            }

            public void Notificacion()
            {
                Console.WriteLine($"Notificacion por el correo electronico a: {CorreoElectronico}");
            }
        }

        public class NotificaciondeWhatsap : INotificable
        {
            private string numerodeTelefono;

            public NotificaciondeWhatsap(string numeroTelefono)
            {
                this.numerodeTelefono = numeroTelefono;
            }

            public void Notificacion()
            {
                Console.WriteLine($"Notificacion por Whatsapp a: {numerodeTelefono}");
            }
        }

        public class NotificaciondeTelefono : INotificable
        {
            private string numerodeTelefono;

            public NotificaciondeTelefono(string numeroTelefono)
            {
                this.numerodeTelefono = numeroTelefono;
            }

            public void Notificacion()
            {
                Console.WriteLine($"Notificacion por Mensaje a: {numerodeTelefono}");
            }
        }
    }
}
