using AmistServer.Object;
using CustomerCors.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using MySqlConnector;
using System.Data;
using System.Linq;
using CustomerCors.ErrorMsg;

namespace InterStructor.Service
{
    public class EmployeeRepo : MISABaseRepo<Employee>, IEmployeeRepo
    {
        #region Instructor
        public EmployeeRepo():base()
        {

        }

        public ServiceResult GetNewEmployeeCode()
        {
            var res = GetAllCode();
            var result = new ServiceResult();
            if(res.isValid == false)
            {
                result.isValid = false;
                result.ErrorMsg.Add("Lỗi Server!, Không lấy được dữ liệu");
                return result;
            }
            var employeesCode = res.Data.ElementAt(0);
            var code = new List<int>();
            foreach(var employeeCode in (List<string>)employeesCode)
            {
                var codeTitle = employeeCode.Substring(0, 2);
                if(codeTitle == "MF") 
                {
                    code.Add(int.Parse(employeeCode.Substring(2)));
                }
                
            }
            var newCode = "MF" + (code.Max() + 1).ToString();
            result.Data.Add(newCode);
            return result;
        }
        #endregion
        #region Excute Interface

        public ServiceResult GetPageTen(int index = 1)
        {
            if (index <= 0)
            {
                index = 1;
            }
            var start = (index-1) * 10;
            var sqlCommand = $"select * from {tableName} limit {start}, 10";
            var result = new ServiceResult();
            try
            {
                var entities = this.Connect().Query<Employee>(sqlCommand).ToList();
                result.Data.Add(entities);
                result.ErrorMsg.Add("Lấy dữ liệu thành công!");
            }
            catch (Exception e)
            {
                result.isValid = false;
                result.ErrorMsg.Add(e.Message);
            }
            return result;
        }

        public ServiceResult GetPageTwenty(int index = 1)
        {
            if (index <= 0)
            {
                index = 1;
            }
            var start = (index - 1) * 20;
            var sqlCommand = $"select * from {tableName} limit {start}, 20";
            var result = new ServiceResult();
            try
            {
                var entities = this.Connect().Query<Employee>(sqlCommand).ToList();
                result.Data.Add(entities);
                result.ErrorMsg.Add("Lấy dữ liệu thành công!");
            }
            catch (Exception e)
            {
                result.isValid = false;
                result.ErrorMsg.Add(e.Message);
            }
            return result;
        }
        #endregion
    }
}
