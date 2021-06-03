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
    public class MISABaseRepo<MISAEntity> : IBaseRepo<MISAEntity>
    {
        #region Instructor
        protected string tableName;
        public MISABaseRepo()
        {
            tableName = typeof(MISAEntity).Name;
        }
        #endregion
        #region ConnectDataBase
        protected IDbConnection Connect()
        {
            //string connectionString = "" +
            //    "Host = 47.241.69.179;" +
            //    "Port = 3306;" +
            //    "Database = MF_FS_CukCuk;" +
            //    "User Id = nvmanh;" +
            //    "Password = 12345678;";
            string connectionString = "" +
                "Host = localhost;" +
                "Port = 3306;" +
                "Database = amist-test-hd;" +
                "User Id = root;" +
                "Password = 0matkhau;";
            return new MySqlConnection(connectionString);
        }
        #endregion
        public ServiceResult GetAll()
        {
            var result = new ServiceResult();
            var sqlCommand = $"SELECT * FROM {tableName}";
            try 
            {
                var entities = this.Connect().Query<MISAEntity>(sqlCommand).ToList();
                result.Data.Add(entities);
                result.ErrorMsg.Add("Lấy dữ liệu thành công!");
            }
            catch(Exception e)
            {
                result.isValid = false;
                result.ErrorMsg.Add(e.Message);
            }
            return result;
        }

        public ServiceResult GetbyId(Guid entityId)
        {
            var sqlCommand = $"select * from {tableName} WHERE {tableName}ID = @entityId";
            DynamicParameters param = new DynamicParameters();
            param.Add("@entityId", entityId);
            
            var result = new ServiceResult();
            try
            {
                var entity = this.Connect().QueryFirstOrDefault<MISAEntity>(sqlCommand, param: param);
                result.Data.Add(entity);
                result.ErrorMsg.Add("Lấy dữ liệu thành công!");
            }
            catch (Exception e)
            {
                result.isValid = false;
                result.ErrorMsg.Add(e.Message);
            }
            return result;
        }

        public ServiceResult Insert(MISAEntity entity)
        {
            var sqlCommandField = "";
            var sqlCommandValue = "";
            var properties = entity.GetType().GetProperties();
            DynamicParameters _param = new DynamicParameters();

            int i = 0;
            foreach (var pro in properties)
            {
                i++;
                var propName = pro.Name;
                if (i == properties.Length)
                {
                    sqlCommandField += $"{propName}";
                    sqlCommandValue += $"@{propName}";
                }
                else
                {
                    sqlCommandField += $"{propName},";
                    sqlCommandValue += $"@{propName},";
                }

            }
            var sqlCommand = $"insert into {tableName} ({sqlCommandField}) values ({sqlCommandValue})";
            foreach (var pro in properties)
            {
                var propName = pro.Name;
                var propValue = pro.GetValue(entity);
                if (propName == $"{tableName}Id")
                {
                    propValue = Guid.NewGuid().ToString();
                }
                _param.Add($"@{propName}", propValue);
            }
            var result = new ServiceResult();
            try
            {
                var res = this.Connect().Execute(sqlCommand, param: _param);
                result.Data.Add(res);
                result.ErrorMsg.Add("Thêm dữ liệu thành công!");
            }
            catch (Exception e)
            {
                result.isValid = false;
                result.ErrorMsg.Add(e.Message);
            }
            return result;
        }

        public ServiceResult Update(MISAEntity entity, Guid entityId)
        {
            var sqlCommandValue = "";
            var properties = entity.GetType().GetProperties();
            var condition = "";
            DynamicParameters param = new DynamicParameters();

            var i = 0;
            foreach (var prop in properties)
            {
                var propName = prop.Name;
                var propValue = prop.GetValue(entity);
                if (i == 0)
                {
                    condition = $"{propName} = @{propName}";
                    i++;
                }
                else if (i == properties.Length - 1)
                {
                    sqlCommandValue += $"{propName} = @{propName}";
                    i++;
                }
                else
                {

                    sqlCommandValue += $"{propName} = @{propName},";
                    i++;
                }
            }
            // Khởi tạo câu lệnh truy vấn
            var sqlCommand = $"UPDATE {tableName} SET {sqlCommandValue} WHERE {condition}";
            foreach (var pro in properties)
            {
                var propName = pro.Name;
                var propValue = pro.GetValue(entity);
                param.Add($"@{propName}", propValue);
            }
            var result = new ServiceResult();
            // Request tới server
            try
            {
                var res = this.Connect().Execute(sqlCommand, param: param);
                result.Data.Add(res);
                result.ErrorMsg.Add("Chỉnh sửa thành công!");
            }
            catch (Exception e)
            {
                result.isValid = false;
                result.ErrorMsg.Add(e.Message);
            }
            return result;
        }
        public ServiceResult Delete(Guid entityId)
        {
            var sqlCommand = $"delete from {tableName} WHERE {tableName}ID = @entityId";
            DynamicParameters param = new DynamicParameters();
            param.Add("@entityId", entityId);
            var result = new ServiceResult();
            try
            {
                var res = this.Connect().Execute(sqlCommand, param: param);
                result.Data.Add(res);
                result.ErrorMsg.Add("Xóa dữ liệu thành công!");
            }
            catch (Exception e)
            {
                result.isValid = false;
                result.ErrorMsg.Add(e.Message);
            }
            return result;
        }

        public ServiceResult GetAllCode()
        {
            var sqlCommand = $"SELECT {tableName}Code from {tableName}";
            var result = new ServiceResult();
            try 
            {
                var res = this.Connect().Query<string>(sqlCommand).ToList();
                result.Data.Add(res);
            }
            catch(Exception e)
            {
                result.isValid = false;
                result.ErrorMsg.Add(e.Message);
            }
            return result;
        }
    }
}
