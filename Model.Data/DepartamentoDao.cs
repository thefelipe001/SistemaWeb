using Model.Entity;
using Model.Entity.Moldes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class DepartamentoDao
    {

        //Mostrar Los Departamento
        public List<Departamento> Mostrar()
        {
            using (var data=new ApplicationDB())
            {
                return data.Departamento.OrderBy(x => x.IdDepartamento).ToList();
            }
        }
        //Obtener Por ID
        public Departamento ObtenerID(int id)
        {
            using (var data=new ApplicationDB())
            {
                return data.Departamento.Where(x => x.IdDepartamento == id).FirstOrDefault();

            }
        }
        //Agregar Departamento
        public void Agregar(Departamento departamento)
        {
            using (var data=new ApplicationDB())
            {
                data.Departamento.Add(departamento);
                data.SaveChanges();
            }
        }


        //Actualizar Departamento
        public void Actualizar(Departamento departamento)
        {
            using (var data=new ApplicationDB())
            {
               var d= data.Departamento.Find(departamento.IdDepartamento);
                d.NombreDepartamento = departamento.NombreDepartamento;
                data.SaveChanges();
            }
        }

        //Eliminar Departamento
        public void Eliminar(int id)
        {
            using (var data=new ApplicationDB())
            {
                var lista= data.Departamento.Find(id);
                data.Departamento.Remove(lista);
                data.SaveChanges();
            }
        }

        //Mostrar Cliente Por Departamento
        public List<ClienteEntity>MostrarClient(ClienteEntity departamento)
        {
            string sql = "select c.IdCliente,c.Nombres,c.Apellidos,c.Celular,c.Email,d.NombreDepartamento from Cliente c inner join Departamento d on c.DepartamentoId=d.IdDepartamento  where c.DepartamentoId='"+departamento.DepartamentoId+"'";


            using (var data=new ApplicationDB())
            {
                return data.Database.SqlQuery<ClienteEntity>(sql).ToList();
            }
        }
        


    }
}
