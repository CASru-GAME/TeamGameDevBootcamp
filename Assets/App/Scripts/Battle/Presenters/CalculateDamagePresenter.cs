using App.Battle.UseCases;
using App.Common.Data.MasterData;
using App.Common.Data;

namespace App.Battle.Presenters
{
    public class CalculateDamagePresenter
    {
        public HealthPoint CalculateDamage(CharacterParameter player, BattleSkillData skill, EnemyMasterData enemy)
        {
            HealthPoint damage = new HealthPoint(player.Atk.CurrentValue*skill.AtkRate - enemy.CharacterParameter.Def.CurrentValue);
            HealthPoint matdamage = new HealthPoint(player.Mat.CurrentValue*skill.MatRate - enemy.CharacterParameter.Mde.CurrentValue);

            damage = damage.AddCurrentValue(matdamage);

            return damage;
        }
    }
}