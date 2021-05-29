using AmistServer.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerCors.Interface
{
    // Interface để lọc kiểm tra data trước khi đưa vào thực thi
    public interface ICustomerFilterData:IBaseService<Employee>
    {
        /// <summary>
        /// Hàm kiểm tra một data có hợp lệ hay không
        /// </summary>
        /// <returns></returns>
        public bool ValidateEmployee(Employee employee);
    }
}
