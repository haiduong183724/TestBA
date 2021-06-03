using CustomerCors.ErrorMsg;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerCors.Interface
{
    public interface IBaseService<MISAEntity>
    {
        /// <summary>
        /// Thêm mới
        /// </summary>
        /// <param name="entity">Đối tượng thêm mới</param>
        /// <returns>Số bản ghi thêm mới thành công</returns>
        /// CreateBy: NHDUONG 29/5
        public ServiceResult Insert(MISAEntity entity);
        /// <summary>
        /// Chỉnh sửa
        /// </summary>
        /// <param name="entity"> Đối tượng chỉnh sửa, Id của đối tượng chỉnh sửa</param>
        /// <returns> số bản ghi được chỉnh sửa</returns>
        /// CreadteBy: NHDUONG 29/5
        public ServiceResult Update(MISAEntity entity, Guid entityId);
        /// <summary>
        /// Kiểm tra mã code của đối tượng đã có hay chưa
        /// </summary>
        /// <param name="entityCode"> Mã code của đối tượng</param>
        /// <returns> kiểu Service Resutl thông báo mã code của đối tượng đã có hay chưa</returns>
        public ServiceResult CheckCode(String entityCode);
    }
}
