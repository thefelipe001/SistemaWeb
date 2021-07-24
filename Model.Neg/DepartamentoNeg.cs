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
    public class DepartamentoNeg
    {
        // instancia  de la Clase DepartamnetoDao
        private static DepartamentoDao dao = new Data.DepartamentoDao();
        //Lista de Departamento
        public static List<Departamento> Mostrar() 
        {
            return dao.Mostrar();
        
        }
        //Obtener Departamento por ID
        public static Departamento ObtenerID(int id)
        {
            return dao.ObtenerID(id);
        }

        //Agregar Departamento
        public static void Agregar(Departamento departamento)
        {
            dao.Agregar(departamento);

        }
        // Modificar Departamento
        public static void Modificar(Departamento departamento)
        {
            dao.Actualizar(departamento);
        }


        //Eliminar Departamento
        public static void Eliminar(int id)
        {
            dao.Eliminar(id);
        }
        //Mostrar Cliente por Departamento
        public static List<ClienteEntity> MostrarClient(ClienteEntity departamento)
        {
            return dao.MostrarClient(departamento);
        }

    }
}
