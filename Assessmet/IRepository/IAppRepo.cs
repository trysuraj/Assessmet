using Assessmet.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessmet.IRepository
{
    public class IAppRepo
    {
        Task<ProgramInfoDTO> GetProgram(string Id);
        Task<List<ProgramInfoDTO>> GetAllProgram();
        Task<bool> UpdateProgram(ProgramInfoDTO program, string Id);
        Task<string> Add(AppDTO application);
        Task<bool> Remove(string Id);
    }
}
