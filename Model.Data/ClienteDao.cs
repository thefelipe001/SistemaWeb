using Model.Entity;
using Model.Entity.Moldes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
   public class ClienteDao
    {
        //Mostrar los Empleado con su Departamento
        public List<ClienteEntity> Mostrar() 
        {
         string sql = @"select e.IdCliente,e.Nombres,e.Apellidos,e.Email,e.Celular,d.IdDepartamento,d.NombreDepartamento from Cliente 
         e inner join Departamento d on e.DepartamentoId=d.IdDepartamento";
            using (var data=new ApplicationDB())
            {
                return data.Database.SqlQuery<ClienteEntity>(sql).ToList();
            }

        }
        //Agregar Empleado
        public void  Agregar( Cliente cliente)
        {
            using (var data=new ApplicationDB())
            {
                data.Cliente.Add(cliente);
                data.SaveChanges();
            }

        }
        //Eliminar Empleado
        public void Eliminar(int id)
        {
            using (var data=new ApplicationDB())
            {
              var lista= data.Cliente.Find(id);
                data.Cliente.Remove(lista);
                data.SaveChanges();
                
            }
        }
    }
}
