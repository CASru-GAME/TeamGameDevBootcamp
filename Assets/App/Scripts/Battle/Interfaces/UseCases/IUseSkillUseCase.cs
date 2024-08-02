using App.Battle.Data;
using App.Common.Data;
using App.Common.Data.MasterData;

namespace App.Battle.Interfaces.UseCases
{
    public interface IUseSkillUseCase
    {
        void UseSkill(CharacterParameter player, int skillId, int enemyId);
    }
}