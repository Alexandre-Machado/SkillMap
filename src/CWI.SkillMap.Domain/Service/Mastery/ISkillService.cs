namespace CWI.SkillMap.Domain.Service
{
    using Model;
    using System.Collections.Generic;

    public interface IMasteryService
    {
        List<MasteryModel> GetAllMasteries();
    }
}
