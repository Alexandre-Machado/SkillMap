using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CWI.SkillMap.Domain.Model;
using Microsoft.Framework.DependencyInjection;
using CWI.SkillMap.Domain.Repository;

namespace CWI.SkillMap.Domain.Service
{
    public class SkillService : BaseService, ISkillService
    {
        public SkillService(IProfileRepository _profileRepository)
        {
            profileRepository = _profileRepository;
        }
        
        public List<ProfileModel> GetAllProfiles()
        {
            return profileRepository.GetAll().Select(_ => new ProfileModel
            {
                Email = _.Email,
                Name = _.Name
            }).ToList();
        }

        public List<ProfileModel> GetAllSkills()
        {
            throw new NotImplementedException();
        }
    }
}
