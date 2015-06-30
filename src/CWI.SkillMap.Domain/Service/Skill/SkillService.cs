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
        public SkillService(ISkillRepository _skillRepository)
        {
            skillRepository = _skillRepository;
        }

        public List<SkillModel> GetAllSkills()
        {
            return skillRepository.GetAll().Select(_ => new SkillModel
            {
                Name = _.SkillName
            }).ToList();
        }
    }
}
