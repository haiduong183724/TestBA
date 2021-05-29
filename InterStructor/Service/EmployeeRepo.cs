using AmistServer.Object;
using CustomerCors.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using MySqlConnector;
using System.Data;
using System.Linq;

namespace InterStructor.Service
{
    public class EmployeeRepo : MISABaseRepo<Employee>, ICustomerExcute
    {
        #region Instructor
        public EmployeeRepo():base()
        {

        }
        #endregion
        #region Excute Interface
        public bool CheckCodeExits(string employeeCode)
        {
            var sqlCommand = $"select * from {tableName} where {tableName}Code = @employeeCode";
            DynamicParameters param = new DynamicParameters();
            param.Add($"@{tableName}Code", employeeCode);
            var employee = this.Connect().QueryFirstOrDefault<Employee>(sqlCommand, param:param);
            if(employee == null)
            {
                return false;
            }
            return true;
        }

        public List<Employee> GetPageTen(int index)
        {
            var start = (index-1) * 10;
            var sqlCommand = $"select * from {tableName} limit {start}, 10";
            var employees = this.Connect().Query<Employee>(sqlCommand).ToList();
            return employees;
        }

        public List<Employee> GetPageTwenty(int index)
        {
            var start = (index - 1) * 20;
            var sqlCommand = $"select * from {tableName} limit {start}, 20";
            var employees = this.Connect().Query<Employee>(sqlCommand).ToList();
            return employees;
        }
        #endregion
    }
}
