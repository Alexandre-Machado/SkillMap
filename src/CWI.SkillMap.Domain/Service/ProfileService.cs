using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CWI.SkillMap.Domain.Model;
using Microsoft.Framework.DependencyInjection;
using CWI.SkillMap.Domain.Repository;

namespace CWI.SkillMap.Domain.Service
{
    public class ProfileService : BaseService, IProfileService
    {
        public ProfileService(IProfileRepository _profileRepository)
        {
            profileRepository = _profileRepository;
        }

        public ProfileModel CurrentProfile()
        {
            var profile = profileRepository.GetProfileByLogin("");

            return new ProfileModel
            {
                Name = profile.Name,
                Email = profile.Email
            };
        }
    }
}
