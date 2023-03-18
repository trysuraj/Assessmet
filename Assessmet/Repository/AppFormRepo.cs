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
    public class AppFormRepo : IAppFormRepo
    {
        private readonly AppDbContext _context;

        public AppFormRepo (AppDbContext context)
        {
            _context = context;
        }

        public async Task<AppFormDTO> GetTemplate(string Id)
        {
            var data = await _context.application.FirstOrDefaultAsync(x => x.ApplicationId == Id);
            if (data == null) return null;

            return new AppFormDTO()
            {
                Educations = data.Educations,
                IdNumber = data.IdNumber,
                Email = data.Email,
                Experiences = data.Experiences,
                FirstName = data.FirstName,
                LastName = data.LastName,
                Gender = data.Gender,
                ImageUpload = data.ImageUpload,
                Nationality = data.Nationality,
                Phone = data.Phone,
                CurrentResidence = data.CurrentResidence,
                Resume = data.Resume
            };
        }

        public async Task<bool> UpdateTemplate(AppFormDTO program, string Id)
        {
            var data = await _context.application.FirstOrDefaultAsync(x => x.ApplicationId == Id);

            if (data == null) return false;

            data.IdNumber = program.IdNumber;
            data.Email = program.Email;
            data.FirstName = program.FirstName;
            data.LastName = program.LastName;
            data.Gender = program.Gender;
            data.ImageUpload = program.ImageUpload;
            data.Nationality = program.Nationality;
            data.Phone = program.Phone;
            data.CurrentResidence = program.CurrentResidence;
            data.Resume = program.Resume;
            data.Experiences = program.Experiences;
            data.Educations = program.Educations;

            _context.Update(data);
            return _context.SaveChanges() > 0;
        }
    }
}
