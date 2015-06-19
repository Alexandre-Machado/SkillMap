using CWI.SkillMap.Domain.Model;
using System.Threading.Tasks;

namespace CWI.SkillMap.Domain.Service
{
    public interface IProfileService
    {
        Task<ProfileModel> CurrentProfile();
    }
}
