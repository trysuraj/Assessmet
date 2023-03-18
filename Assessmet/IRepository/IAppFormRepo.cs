using Assessmet.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessmet.IRepository
{
    public class IAppFormRepo
    {
        Task<AppFormDTO> GetTemplate(string Id);
        Task<bool> UpdateTemplate(AppFormDTO program, string Id);
    }
}
