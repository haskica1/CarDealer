using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Models;
using System.Data;
using Dapper;

namespace CarDealer.DataAccess
{
    public class SQLDataAccess
    {
        private IDbConnection connection = null;
        public SQLDataAccess() 
        {
            connection = new System.Data.SqlClient.SqlConnection(GlobalConfigurations.ConnString("CarDealerDB"));
        }

        internal List<Car> GetAllVehicles()
        {

                var rez = connection.Query<Car>("dbo.GetAllCars").ToList();
                return rez;
      
        }

        internal void AddCar(Car car)
        {
            /*var p = new DynamicParameters();
            p.Add("@brand",car.Brand);
            p.Add("@model",car.Model);
            p.Add("@color",car.Color);
            p.Add("@engine",car.Engine);
            p.Add("@chassis",car.Chassis);
            p.Add("@price",car.Price);

            connection.Execute("dbo.AddCar", p, commandType: CommandType.StoredProcedure);*/
            
        }

        internal void AddEquipment(Equipment equipment)
        {
            var p = new DynamicParameters();
            p.Add("@name", equipment.Name);
            p.Add("@info", equipment.Info);

            connection.Execute("dbo.AddEquipment", p, commandType: CommandType.StoredProcedure);
        }
    }
}
