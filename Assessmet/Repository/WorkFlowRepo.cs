using Assessmet.Context;
using Assessmet.DTOs;
using Assessmet.IRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessmet.Repository 
{
    public class WorkFlowRepo :IWorkFlowRepo
    {
        private readonly AppDbContext _context;

        public WorkFlowRepo(AppDbContext context)
        {
            _context = context;
        }


        public async Task<WorkFlowDTO> GetWorkflow(string Id)
        {
            var data = await _context.application.FirstOrDefaultAsync(x => x.ApplicationId == Id);
            if (data == null) return null;

            return new WorkFlowDTO()
            {
                stages = data.stages
            };
        }

        public async Task<bool> UpdateWorkflow(WorkFlowDTO program, string Id)
        {
            var data = await _context.application.FirstOrDefaultAsync(x => x.ApplicationId == Id);

            if (data == null) return false;

            data.stages = program.stages;

            _context.Update(data);
            return _context.SaveChanges() > 0;
        }
    }
}
