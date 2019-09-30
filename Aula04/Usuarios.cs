using System;

namespace Aula3
{
    public class Usuarios
    {
        private string nome{ get; set; }
        private string local{ get; set; }
        private string telefone{ get; set; }
        private string senha{ get; set; }

        public void FazReserva(){
            Console.WriteLine("Reservar");
        }
    }
}