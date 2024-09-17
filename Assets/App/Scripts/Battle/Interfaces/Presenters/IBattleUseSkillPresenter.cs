using App.Battle.Data;
using App.Common.Data;
using App.Common.Data.MasterData;

namespace App.Battle.Interfaces.Presenters
{
    public interface IBattleUseSkillPresenter
    {
        HealthPoint CalculateDamage(CharacterParameter player, BattleSkillData skill, Enemy enemy);
    }
}