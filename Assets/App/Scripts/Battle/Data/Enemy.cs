using App.Common.Data;

namespace App.Battle.Data
{
    public class Enemy
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public HealthPoint Hp;
        public MagicPoint Mp;
        public AttackPoint Atk;
        public MagicAttackPoint Mat;
        public DefensePoint Def;
        public MagicDefensePoint Mde;
    }
}