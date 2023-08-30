using PetPal.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPal.Domain.Response
{
    public class BaseResponse<T> : IBaseResponse<T>
    {
        public string Descriptions { get; set; }
        public StatusCode StatusCode { get; set; }
        public T Data { get; set; }

    }

    public interface IBaseResponse<T>
    {
        string Descriptions { get;}
        StatusCode StatusCode { get;}
        T Data { get;}
    }
}
