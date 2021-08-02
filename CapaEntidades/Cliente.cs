using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class Cliente
    {
        int IDClienteConexion;
        int IdCliente;
        DateTime Fecha;
        bool IsConectado;

        public Cliente(int iDClienteConexion, int idCliente, DateTime fecha, bool isConectado)
        {
            IDClienteConexion = iDClienteConexion;
            IdCliente = idCliente;
            Fecha = fecha;
            IsConectado = isConectado;
        }

        public int IDClienteConexion1 { get => IDClienteConexion; set => IDClienteConexion = value; }
        public int IdCliente1 { get => IdCliente; set => IdCliente = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public bool IsConectado1 { get => IsConectado; set => IsConectado = value; }
    }
}
