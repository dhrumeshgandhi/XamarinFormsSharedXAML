using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XFSX_Test_1
{
    interface IRestService<T>
    {
        Task<List<T>> RefreshDataAsync();

        Task SaveItemAsync(T user, bool isNewItem);

        Task DeleteItemAsync(string id);
    }
}
