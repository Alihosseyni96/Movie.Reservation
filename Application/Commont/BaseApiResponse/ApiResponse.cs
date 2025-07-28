using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commont.BaseApiResponse
{
    public class ApiResponse<T>
    {
        public bool IsSucess { get; set; }
        public T? Data { get; set; }
        public List<string>? Errors { get; set; }


        public static ApiResponse<T> Success(T? data)
        {
            return new ApiResponse<T>
            {
                IsSucess = true,
                Data = data,
            };
        }

        public static ApiResponse<T> Fail( List<string>? errors = null)
        {
            return new ApiResponse<T>
            {
                IsSucess = false,
                Errors = errors,
            };
        }
    }
}
