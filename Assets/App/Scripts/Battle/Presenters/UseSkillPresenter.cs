using App.Common.Data.MasterData;
using App.Battle.Data;
using App.Common.Data;
using Cysharp.Threading.Tasks.Triggers;

namespace App.Battle.Presenters
{
    public class UseSkillPresenter
    {
        private readonly BattleSkillDataBase _battleSkillDataBase;
        private readonly EnemyMasterDataBase _enemyMasterDataBase;

        public UseSkillPresenter(BattleSkillDataBase battleSkillDataBase, EnemyMasterDataBase enemyMasterDataBase)
        {
            _battleSkillDataBase = battleSkillDataBase;
            _enemyMasterDataBase = enemyMasterDataBase;
        }

        private HealthPoint CalculateDamage(CharacterParameter player, BattleSkillData skill, EnemyMasterData enemy)
        {
            HealthPoint damage = new HealthPoint(player.Atk.CurrentValue*skill.AtkRate - enemy.CharacterParameter.Def.CurrentValue);
            HealthPoint matdamage = new HealthPoint(player.Mat.CurrentValue*skill.MatRate - enemy.CharacterParameter.Mde.CurrentValue);

            damage = damage.AddCurrentValue(matdamage);

            return damage;
        }

        public void UseSkill(CharacterParameter player, int skillId, int enemyId)
        {
            var skill = _battleSkillDataBase.BattleSkillData[skillId];
            var enemy = _enemyMasterDataBase.EnemyMasterData[enemyId];

            HealthPoint damage = CalculateDamage(player, skill, enemy);
            MagicPoint consumeMp = new MagicPoint(skill.CnsMp);

            enemy.CharacterParameter.Hp = enemy.CharacterParameter.Hp.SubtractCurrentValue(damage);
            player.Mp = player.Mp.SubtractCurrentValue(consumeMp);
        }
    }
}