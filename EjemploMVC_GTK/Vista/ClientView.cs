using System;
namespace EjemploMVC_GTK.Vista
{
    public class ClientView
    {
        public void imprimirCliente (int id, String nombre, String apellido)
        {
            Console.WriteLine("---------DATOS DEL CLIENTE-------------");
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido:" + apellido);
        }

    }
}
