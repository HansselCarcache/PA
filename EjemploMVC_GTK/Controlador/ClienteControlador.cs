using System;
using EjemploMVC_GTK.Modelo;
using EjemploMVC_GTK.Vista;

namespace EjemploMVC_GTK.Controlador
{
    public class ClienteControlador
    {
        public Cliente _modelo;
        public ClientView _vista;

        public ClienteControlador(Cliente modelo, ClientView vista)
        {
            _modelo = modelo;
            _vista = vista;
        }

        public void actualizarVista()
        {
            _vista.imprimirCliente(_modelo.id, _modelo.nombre, _modelo.apellido);
        }
    }
}
