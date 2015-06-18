using CWI.SkillMap.Domain.Model;
using CWI.SkillMap.Domain.Repository;
using CWI.SkillMap.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWI.SkillMap.Domain
{
    public class ProfileService : BaseService, IProfileService
    {
        public ProfileModel CurrentProfile()
        {
            using (var context = new ApplicationDbContext())
            {
                var prof = context.Profiles.Single(_ => _.Login == "");
                return null;
            }
        }
    }
}
