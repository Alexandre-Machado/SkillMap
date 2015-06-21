namespace CWI.SkillMap.Domain.Service
{
    using Model;
    using System.Collections.Generic;

    public interface IProfileService
    {
        ProfileModel CurrentProfile();

        List<ProfileModel> GetAllProfiles();
    }
}
