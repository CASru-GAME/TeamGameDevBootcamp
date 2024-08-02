using App.Common.Data.MasterData;
using App.Common.Data;
using App.Battle.Presenters;
using App.Battle.Interfaces.UseCases;

namespace App.Battle.UseCases
{
    public class BattleUseSkillUseCase: IUseSkillUseCase
    {
        private readonly BattleSkillDataBase _battleSkillDataBase;
        private readonly EnemyMasterDataBase _enemyMasterDataBase;

        public BattleUseSkillUseCase(BattleSkillDataBase battleSkillDataBase, EnemyMasterDataBase enemyMasterDataBase)
        {
            _battleSkillDataBase = battleSkillDataBase;
            _enemyMasterDataBase = enemyMasterDataBase;
        }

        public void UseSkill(CharacterParameter player, int skillId, int enemyId)
        {
            var skill = _battleSkillDataBase.BattleSkillData[skillId];
            var enemy = _enemyMasterDataBase.EnemyMasterData[enemyId];

            if (player.Mp.CurrentValue < skill.ConsumeMp) return;

            BattleUseSkillPresenter useSkillPresenter = new BattleUseSkillPresenter();
            HealthPoint damage = useSkillPresenter.CalculateDamage(player, skill, enemy);

            MagicPoint consumeMp = new MagicPoint(skill.ConsumeMp);
            enemy.CharacterParameter.Hp = enemy.CharacterParameter.Hp.SubtractCurrentValue(damage);
            player.Mp = player.Mp.SubtractCurrentValue(consumeMp);
        }
    }
}