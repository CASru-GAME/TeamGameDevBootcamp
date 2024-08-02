using App.Common.Data;

namespace App.Battle.Data
{
    [System.Serializable]
    public class BattleSkillParameter
    {
        public string Name { get; private set; }
        public HealthPoint Hp;
        public MagicPoint Mp;
        public AttackPoint Atk;
        public MagicAttackPoint Mat;

        public BattleSkillParameter(string name, int hp, int mp, int atk, int mat)
        {
            Name = name;
            Mp = new MagicPoint(mp);
            Atk = new AttackPoint(atk);
            Mat = new MagicAttackPoint(mat);
        }

        // This constructor will be deleted.
        public BattleSkillParameter()
        {
            Name = "Default";
            Mp = new MagicPoint(100);
            Atk = new AttackPoint(10);
            Mat = new MagicAttackPoint(10);
        }
    }
}