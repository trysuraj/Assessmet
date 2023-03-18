﻿using Assessmet.Context;
using Assessmet.DTOs;
using Assessmet.IRepository;
using Assessmet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessmet.Repository
{
    public class AppRepo :IAppRepo
    {
        readonly AppDbContext _context;
        public AppRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task<string> Add(AppDTO application)
        {
            if (application == null) return null;

            try
            {
                var data = new ApplicationForm()
                {
                    ApplicationId = Guid.NewGuid().ToString(),
                    ImageUpload = application.ImageUpload,
                    Resume = application.Resume,
                    FirstName = application.FirstName,
                    LastName = application.LastName,
                    Email = application.Email,
                    Phone = application.Phone,
                    Nationality = application.Nationality,
                    CurrentResidence = application.CurrentResidence,
                    IdNumber = application.IdNumber,
                    Gender = application.Gender,
                    Educations = application.Educations,
                    Experiences = application.Experiences,
                    stages = application.stages,
                    ProgramType = application.ProgramType,
                    ProgramStart = application.ProgramStart,
                    ApplciationOpen = application.ApplciationOpen,
                    ApplicationClose = application.ApplicationClose,
                    Duration = application.Duration,
                    Location = application.Location,
                    MinQualification = application.MinQualification,
                    ProgramTitle = application.ProgramTitle,
                    ProgramSummary = application.ProgramSummary,
                    ProgramDescription = application.ProgramDescription,
                    KeySkills = application.KeySkills,
                    ProgramBenefits = application.ProgramBenefits,
                    ApplicationCriteria = application.ApplicationCriteria
                };

                await _context.AddAsync(data);
                var newdata = await _context.SaveChangesAsync();

                return newdata.ToString();
            }
            catch (DbUpdateException ex)
            {

                return ex.InnerException?.Message;

            }
        }
        public async Task<ProgramInfoDTO> GetProgram(string Id)
        {
            var data = await _context.application.FirstOrDefaultAsync(x => x.ApplicationId == Id);
            if (data == null) return null;

            return new ProgramInfoDTO()
            {
                Duration = data.Duration,
                ProgramDescription = data.ProgramDescription,
                ApplciationOpen = data.ApplciationOpen,
                ApplicationClose = data.ApplicationClose,
                ApplicationCriteria = data.ApplicationCriteria,
                KeySkills = data.KeySkills,
                MaxApplications = data.MaxApplications,
                MinQualification = data.MinQualification,
                ProgramBenefits = data.ProgramBenefits,
                Location = data.Location,
                ProgramStart = data.ProgramStart,
                ProgramSummary = data.ProgramSummary,
                ProgramTitle = data.ProgramTitle,
                ProgramType = data.ProgramType
            };
        }
        public async Task<List<ProgramInfoDTO>> GetAllProgram()
        {

            return await _context.application.Select(x =>
            new ProgramInfoDTO()
            {
                Duration = x.Duration,
                ProgramDescription = x.ProgramDescription,
                ApplciationOpen = x.ApplciationOpen,
                ApplicationClose = x.ApplicationClose,
                ApplicationCriteria = x.ApplicationCriteria,
                KeySkills = x.KeySkills,
                MaxApplications = x.MaxApplications,
                MinQualification = x.MinQualification,
                ProgramBenefits = x.ProgramBenefits,
                Location = x.Location,
                ProgramStart = x.ProgramStart,
                ProgramSummary = x.ProgramSummary,
                ProgramTitle = x.ProgramTitle,
                ProgramType = x.ProgramType
            }).ToListAsync();
        }
        public Task<bool> Remove(string Id)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> UpdateProgram(ProgramInfoDTO program, string Id)
        {
            var data = await _context.application.FirstOrDefaultAsync(x => x.ApplicationId == Id);

            if (data == null) return false;

            data.Duration = program.Duration;
            data.ProgramDescription = program.ProgramDescription;
            data.ApplciationOpen = program.ApplciationOpen;
            data.ApplicationClose = program.ApplicationClose;
            data.ApplicationCriteria = program.ApplicationCriteria;
            data.KeySkills = program.KeySkills;
            data.MaxApplications = program.MaxApplications;
            data.MinQualification = program.MinQualification;
            data.ProgramBenefits = program.ProgramBenefits;
            data.Location = program.Location;
            data.ProgramStart = program.ProgramStart;
            data.ProgramSummary = program.ProgramSummary;
            data.ProgramTitle = program.ProgramTitle;
            data.ProgramType = program.ProgramType;

            _context.Update(data);
            return _context.SaveChanges() > 0;
        }
    }
}
