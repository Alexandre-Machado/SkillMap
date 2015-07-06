using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CWI.SkillMap.Domain.Model;
using Microsoft.Framework.DependencyInjection;
using CWI.SkillMap.Domain.Repository;

namespace CWI.SkillMap.Domain.Service
{
    public class MasteryService : BaseService, IMasteryService
    {
        public MasteryService(IMasteryRepository _MasteryRepository)
        {
            masteryRepository = _MasteryRepository;
        }

        public List<MasteryModel> GetAllMasteries()
        {
            return masteryRepository.GetAll().Select(_ => new MasteryModel
            {

            }).ToList();
        }
    }
}
