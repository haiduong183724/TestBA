using CustomerCors.Interface;
using System;
using System.Collections.Generic;
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
        #endregion

        #region ExcuteInterface
        public int? Insert(MISAEntity entity)
        {
            if (ValidateData(entity)) 
            {
                return null;
            }
            return _baseRepo.Insert(entity);
        }

        public int? Update(MISAEntity entity, Guid entityId)
        {
            
            return _baseRepo.Update(entity, entityId);
           
        }
        #endregion
        /// <summary>
        /// hàm validate dữ liệu.
        /// </summary>
        protected virtual bool ValidateData(MISAEntity entity) {
            return true;
        }
    }
}
