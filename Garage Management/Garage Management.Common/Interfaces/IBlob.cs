using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.Common.Interfaces
{
    public interface IBlob
    {
        Task<Uri> UploadImage(string filepath);
    }
}
