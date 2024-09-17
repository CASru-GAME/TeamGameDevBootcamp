using App.Common.Data.MasterData;
using App.Common.Data;
using App.Battle.Interfaces.Presenters;
using App.Battle.Data;

namespace App.Battle.Presenters
{
    public class BattleUseSkillPresenter: IBattleUseSkillPresenter
    {
        public HealthPoint CalculateDamage(CharacterParameter player, BattleSkillData skill, Enemy enemy)
        {
            HealthPoint damage = new HealthPoint(player.Atk.CurrentValue*skill.AtkRate - enemy.characterParameter.Def.CurrentValue);
            HealthPoint matdamage = new HealthPoint(player.Mat.CurrentValue*skill.MatRate - enemy.characterParameter.Mde.CurrentValue);

            damage = damage.AddCurrentValue(matdamage);

            return damage;
        }
    }
}