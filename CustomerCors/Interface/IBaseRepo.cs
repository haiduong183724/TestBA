using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerCors.Interface
{
    public interface IBaseRepo<MISAEntity>
    {
        /// <summary>
        /// Hàm lấy tất cả danh sách
        /// </summary>
        /// <returns>hàm trả về một mảng các thực thể lấy từ bảng</returns>
        public List<MISAEntity> GetAll();
        /// <summary>
        /// Hàm lấy các thực thể dựa trên ID
        /// </summary>
        /// <param name="entityId">hàm truyền vào Id của đối tượng</param>
        /// <returns>trả về một đối tượng phù hợp</returns>
        /// CreateBy:NHDUONG 29/5
        public MISAEntity GetbyId(Guid entityId);
        /// <summary>
        /// Hàm xóa 1 bản ghi 
        /// </summary>
        /// <param name="Id">Truyền vào ID của bản ghi</param>
        /// <returns>Số bản ghi bị xóa</returns>
        /// /// CreateBy:NHDUONG 29/5
        public int? Delete(Guid Id);
        /// <summary>
        /// Hàm chỉnh sửa một đối tượng
        /// </summary>
        /// <param name="entity">Một đối tượng cần chỉnh sửa</param>
        /// <param name="entityId">ID của đối tượng chỉnh sửa</param>
        /// <returns>Số bản ghi bị chỉnh sửa</returns>
        /// /// CreateBy:NHDUONG 29/5
        public int Update(MISAEntity entity, Guid entityId);
        /// <summary>
        /// Hàm thêm một đối tượng
        /// </summary>
        /// <param name="entity">Đối tượng cần thêm vào</param>
        /// <returns>số bản ghi được thêm</returns>
        /// /// CreateBy:NHDUONG 29/5
        public int Insert(MISAEntity entity);
    }
}
