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

        internal List<Car> getAllVehicles()
        {

                var rez = connection.Query<Car>("dbo.GetAllCars").ToList();
                return rez;
      
        }

        internal List<Store> getAllStores()
        {
            var rez = connection.Query<Store>("dbo.GetAllStores").ToList();
            return rez;
        }

        internal List<string> getAllBrands()
        {
            var rez = connection.Query<string>("dbo.GetAllBrands").ToList();
            return rez;
        }

        internal List<string> getAllColors()
        {
            var rez = connection.Query<string>("dbo.GetAllColors").ToList();
            return rez;
        }

        internal List<Equipment> getEquipmentsOfCar(Car car)
        {
            var p = new DynamicParameters();
            p.Add("@carID", car.Id);

            var rez = connection.Query<Equipment>("dbo.GetEquipmentsOfCar", p, commandType: CommandType.StoredProcedure).ToList();
            return rez;
        }

        internal List<string> getAllModels(string brand)
        {
            var p = new DynamicParameters();
            p.Add("@brand", brand);

            var rez = connection.Query<string>("dbo.GetAllModels",p,commandType: CommandType.StoredProcedure).ToList();
            return rez;
        }

        internal List<Employee> getAllEmployees()
        {
            var rez = connection.Query<Employee>("dbo.GetAllEmployees").ToList();
            return rez;
        }

        internal List<Storage> getAllStorages()
        {
            var rez = connection.Query<Storage>("dbo.GetAllStorages").ToList();
            return rez;
        }

        internal List<User> getAllUsers()
        {

            var rez = connection.Query<User>("dbo.GetAllUsers").ToList();
            return rez;

        }

        internal List<Car> searchCar(string brand, string model, string color, string minPrice, string maxPrice)
        {
            var p = new DynamicParameters();
            p.Add("@brand", brand);
            p.Add("@model", model);
            p.Add("@color", color);
            p.Add("@minPrice", minPrice);
            p.Add("@maxPrice", maxPrice);


            var rez = connection.Query<Car>("dbo.SearchCar", p, commandType: CommandType.StoredProcedure).ToList();
            return rez;
        }

        internal int getUserType(User user)
        {

            var p = new DynamicParameters();
            p.Add("@userId", user.Id);

            int rez = connection.Query<int>("dbo.GetUserType",p,commandType: CommandType.StoredProcedure).ToList().First();
            return rez;
        }

        internal User getUserByUsernameAndPassword(string username, string password)
        {
            var p = new DynamicParameters();
            p.Add("@username", username);
            p.Add("@password", password);

            List<User> users = connection.Query<User>("dbo.GetUserByUsernameAndPassword", p, commandType: CommandType.StoredProcedure).ToList();
            if (users.Count != 0)
            {
                User user = users.First();
                return user;
            }
            return null;
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

        internal void AddUser(Customer newUser)
        {
            var p = new DynamicParameters();
            p.Add("@firstName", newUser.FirstName);
            p.Add("@lastName", newUser.LastName);
            p.Add("@phoneNumber", newUser.PhoneNumber);
            p.Add("@address", newUser.Address);
            p.Add("@username", newUser.Username);
            p.Add("@password", newUser.Password);
            p.Add("@email", newUser.Email);
            p.Add("@type", 0);
            p.Add("@temp", 0, DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.AddUser", p, commandType: CommandType.StoredProcedure);

            newUser.Id = p.Get<int>("@temp");
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
