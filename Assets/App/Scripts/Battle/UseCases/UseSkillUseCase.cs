using App.Common.Data.MasterData;
using App.Battle.Data;
using App.Common.Data;
using App.Battle.Presenters;
using Cysharp.Threading.Tasks.Triggers;

namespace App.Battle.UseCases
{
    public class UseSkillUseCase
    {
        private readonly BattleSkillDataBase _battleSkillDataBase;
        private readonly EnemyMasterDataBase _enemyMasterDataBase;

        public UseSkillUseCase(BattleSkillDataBase battleSkillDataBase, EnemyMasterDataBase enemyMasterDataBase)
        {
            _battleSkillDataBase = battleSkillDataBase;
            _enemyMasterDataBase = enemyMasterDataBase;
        }

        public void UseSkill(CharacterParameter player, int skillId, int enemyId)
        {
            var skill = _battleSkillDataBase.BattleSkillData[skillId];
            var enemy = _enemyMasterDataBase.EnemyMasterData[enemyId];

            if (player.Mp.CurrentValue < skill.ConsumeMp) return;

            CalculateDamagePresenter calculateDamagePresenter = new CalculateDamagePresenter();
            HealthPoint damage = calculateDamagePresenter.CalculateDamage(player, skill, enemy);

            MagicPoint consumeMp = new MagicPoint(skill.ConsumeMp);
            enemy.CharacterParameter.Hp = enemy.CharacterParameter.Hp.SubtractCurrentValue(damage);
            player.Mp = player.Mp.SubtractCurrentValue(consumeMp);
        }
    }
}