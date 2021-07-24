using Model.Data;
using Model.Entity;
using Model.Entity.Moldes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Neg
{
    public class ClienteNeg
    {
        //Instancia de la clase ClienteDao
        private static ClienteDao clienteDa=new ClienteDao();
        //Metodo Contructor
       
        //Mostrar Empleado con su Departamento en ClienteNeg
        public static List<ClienteEntity> Mostrar()
        {

            return clienteDa.Mostrar();
        }

        //Agregar Empleado
        public static void Agregar(Cliente cliente)
        {
            clienteDa.Agregar(cliente);
        }
        //Eliminar Empleado
        public static void Eliminar(int id)
        {
            clienteDa.Eliminar(id);
        }
    }
}
