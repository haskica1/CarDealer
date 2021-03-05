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

        internal List<Equipment> GetAllEquipments()
        {
            return connection.Query<Equipment>("dbo.GetAllEquipments").ToList();
        }

        internal void AddCar(Car car, List<Equipment> equipments)
        {
            var p = new DynamicParameters();
            p.Add("@brand",car.Brand);
            p.Add("@model",car.Model);
            p.Add("@color",car.Color);
            p.Add("@engine",car.Engine);
            p.Add("@chassis",car.Chassis);
            p.Add("@price",car.Price);
            p.Add("@temp", 0, DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.AddCar", p, commandType: CommandType.StoredProcedure);

            car.Id = p.Get<int>("@temp");

            foreach (Equipment equipment in equipments)
            {
                if (CheckEquipment(equipment))
                {
                    AddEquipment(equipment);
                }
            }


            WireUpCarAndEquipments(car, equipments);

            
        }

        private void WireUpCarAndEquipments(Car car, List<Equipment> equipments)
        {
            foreach(Equipment equipment in equipments)
            {
                var p = new DynamicParameters();
                p.Add("@equipmentID", equipment.Id);
                p.Add("@carID", car.Id);

                connection.Execute("dbo.AddEquipmentCar", p, commandType: CommandType.StoredProcedure);
            }
        }

        private bool CheckEquipment(Equipment equipment)
        {
            foreach(Equipment e in GetAllEquipments())
            {
                if (e.Name.Equals(equipment.Name)) return false;
            }
            return true;
        }

        internal Equipment AddEquipment(Equipment equipment)
        {
            var p = new DynamicParameters();
            p.Add("@name", equipment.Name);
            p.Add("@info", equipment.Info);
            p.Add("@temp", 0, DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.AddEquipment", p, commandType: CommandType.StoredProcedure);

            equipment.Id = p.Get<int>("@temp");

            return equipment;
        }
    }
}
