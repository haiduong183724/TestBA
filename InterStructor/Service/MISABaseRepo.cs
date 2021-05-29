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
            string connectionString = "" +
                "Host = localhost;" +
                "Port = 3306;" +
                "Database = amist-test-hd;" +
                "User Id = root;" +
                "Password = 0matkhau;";
            return new MySqlConnection(connectionString);
        }
        #endregion
        

        public List<MISAEntity> GetAll()
        {
            var sqlCommand = $"SELECT * FROM {tableName}";
            var entities = this.Connect().Query<MISAEntity>(sqlCommand).ToList();
            return entities; 
        }

        public MISAEntity GetbyId(Guid entityId)
        {
            var sqlCommand = $"select * from {tableName} WHERE {tableName}ID = @entityId";
            DynamicParameters param = new DynamicParameters();
            param.Add("@entityId", entityId);
            var entity = this.Connect().QueryFirstOrDefault<MISAEntity>(sqlCommand, param: param);
            return entity;
        }

        public int Insert(MISAEntity entity)
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
            var res = this.Connect().Execute(sqlCommand, param: _param);

            return res;
        }

        public int Update(MISAEntity entity, Guid entityId)
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
            var sqlCommand = $"UPDATE {tableName} SET {sqlCommandValue} WHERE {condition}";
            foreach (var pro in properties)
            {
                var propName = pro.Name;
                var propValue = pro.GetValue(entity);
                param.Add($"@{propName}", propValue);
            }
            var res = this.Connect().Execute(sqlCommand, param: param);
            return res;
        }
        public int? Delete(Guid entityId)
        {
            var sqlCommand = $"delete from {tableName} WHERE {tableName}ID = @entityId";
            DynamicParameters param = new DynamicParameters();
            param.Add("@entityId", entityId);
            var res = this.Connect().Execute(sqlCommand, param: param);
            return res;
        }
    }
}
