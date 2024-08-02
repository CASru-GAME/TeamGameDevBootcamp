using App.Common.Data;
using App.Common.Data.MasterData;

namespace App.Battle.Interfaces.Presenters
{
    public interface IUseSkillPresenter
    {
        HealthPoint CalculateDamage(CharacterParameter player, BattleSkillData skill, EnemyMasterData enemy);
    }
}