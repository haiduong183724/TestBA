using CustomerCors.Entity;
using CustomerCors.ErrorMsg;
using CustomerCors.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerCors.Service
{
    public class MISABaseService<MISAEntity> : IBaseService<MISAEntity>
    {
        IBaseRepo<MISAEntity> _baseRepo;
        #region Instruction
        public MISABaseService(IBaseRepo<MISAEntity> baseRepo)
        {
            _baseRepo = baseRepo;
        }

        public ServiceResult CheckCode(string entityCode)
        {
            var res = _baseRepo.GetAllCode();
            if(res.isValid == false)
            {
                return res;
            }
            var entitiesCode = res.Data.ElementAt(0);
            var result = new ServiceResult();
            foreach(var entitycode in (List<string>)entitiesCode)
            {
                if(entitycode == entityCode)
                {
                    result.isValid = false;
                    result.ErrorMsg.Add("Mã code đã tồn tại");
                    return result;
                }
            }
            result.ErrorMsg.Add("Mã code chưa tồn tại");
            return result;

        }
        #endregion

        #region ExcuteInterface
        public ServiceResult Insert(MISAEntity entity)
        {
            ServiceResult result = new ServiceResult();
            ValidateData(entity, result);
            if (!result.isValid)
            {
                return result;
            }
            else
            {
                CustomeValidate(entity, result);
                if (result.isValid == false)
                {
                    return result;
                }
                return _baseRepo.Insert(entity);
            }
        }

        public ServiceResult Update(MISAEntity entity, Guid entityId)
        {
            ServiceResult result = new ServiceResult();
            ValidateData(entity, result);
            if (!result.isValid)
            {
                return result;
            }
            else
            {
                CustomeValidate(entity, result);
                if(result.isValid == false)
                {
                    return result;
                }
                return _baseRepo.Update(entity, entityId);
            }
            
        }
        #endregion
        /// <summary>
        /// hàm validate dữ liệu.
        /// </summary>
        protected void ValidateData(MISAEntity entity, ServiceResult result) {
            var properties = entity.GetType().GetProperties();
            // Duyệt các thuộc tính của Entity
            foreach(var prop in properties)
            {
                var propValue = prop.GetValue(entity);
                var propName = prop.Name;
                // Kiểm tra xem chiều dài có lớn hơn 50 kí tự hay không
                if (propValue != null && propValue.ToString().Length > 50)
                {
                    result.isValid = false;
                    result.ErrorMsg.Add($"{propName} vượt quá kí tự cho phép");
                }
                // Kiểm tra giá trị tiền có âm hay không
                if(propValue != null && propValue.GetType() == typeof(double))
                {
                    if((double)propValue < 0)
                    {
                        result.isValid = false;
                        result.ErrorMsg.Add($"{propName} số tiền phải là số dương");
                    }
                }
                // Kiểm tra thời gian trong phạm vi 1/1/2001 => 1/1/2025
                if (propValue != null && propValue.GetType() == typeof(DateTime))
                {
                    DateTime date = (DateTime)propValue;
                    if(date.Year < 2001 || date.Year > 2025)
                    {
                        result.isValid = false;
                        result.ErrorMsg.Add($"{propName} phải trong phạm vi từ 1-1-2001 đến 1-1-2021");
                    }
                    if(date.Year == 2025 && (date.Day>1 || date.Month>1))
                    {
                        result.isValid = false;
                        result.ErrorMsg.Add($"{propName} phải trong phạm vi từ 1-1-2001 đến 1-1-2021");
                    }
                }
                // Kiểm tra các trường bắt buộc nhập
                var propertiesRequired = prop.GetCustomAttributes(typeof(MISARequired), true);
                if (propertiesRequired.Length > 0)
                {
                    if(propValue == null || propName.ToString() == string.Empty)
                    {
                        result.ErrorMsg.Add($"{propName} không được để trống");
                    }
                }
            }
        }

        protected virtual ServiceResult CustomeValidate(MISAEntity entity, ServiceResult result)
        {
            return result;
        }
    }
}
