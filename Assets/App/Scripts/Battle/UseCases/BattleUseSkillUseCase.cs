using App.Common.Data;
using App.Battle.Presenters;
using App.Battle.Interfaces.UseCases;
using App.Battle.Interfaces.Datastores;

namespace App.Battle.UseCases
{
    public class BattleUseSkillUseCase : IBattleUseSkillUseCase
    {
        private readonly IBattleSkillDataBase _battleSkillDataBase;
        private readonly IBattleEnemyDatastore _battleEnemyDatastore;

        public BattleUseSkillUseCase(IBattleSkillDataBase battleSkillDataBase, IBattleEnemyDatastore battleEnemyDatastore)
        {
            _battleSkillDataBase = battleSkillDataBase;
            _battleEnemyDatastore = battleEnemyDatastore;
        }

        public void UseSkill(CharacterParameter player, int skillId, int enemyId)
        {
            var skill = _battleSkillDataBase.[skillId];
            var enemy = _battleEnemyDatastore.GetEnemyBy($"{enemyId}");

            if (player.Mp.CurrentValue < skill.ConsumeMp) return;

            BattleUseSkillPresenter useSkillPresenter = new BattleUseSkillPresenter();
            HealthPoint damage = useSkillPresenter.CalculateDamage(player, skill, enemy);

            MagicPoint consumeMp = new MagicPoint(skill.ConsumeMp);
            enemy.characterParameter.Hp = enemy.characterParameter.Hp.SubtractCurrentValue(damage);
            player.Mp = player.Mp.SubtractCurrentValue(consumeMp);
            UnityEngine.Debug.Log($"{player.Name}は{enemy.characterParameter.Name}に{damage.CurrentValue}のダメージを与えた");
        }
    }
}