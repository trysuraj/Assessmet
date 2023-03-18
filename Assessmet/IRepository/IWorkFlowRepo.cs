using Assessmet.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessmet.IRepository
{
    public class IWorkFlowRepo
    {
        Task<WorkFlowDTO> GetWorkflow(string Id);
        Task<bool> UpdateWorkflow(WorkFlowDTO program, string Id);
    }
}
