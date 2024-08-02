using UnityEngine;

namespace App.Common.Data
{
    [System.Serializable]
    public class CharacterParameter
    {
        public string Name { get; private set; }
        public HealthPoint Hp;
        public MagicPoint Mp;
        public AttackPoint Atk;
        public MagicAttackPoint Mat;
        public DefensePoint Def;
        public MagicDefensePoint Mde;

        public CharacterParameter(string name, int hp, int mp, int atk, int mat, int def, int mde)
        {
            Name = name;
            Hp = new HealthPoint(hp);
            Mp = new MagicPoint(mp);
            Atk = new AttackPoint(atk);
            Mat = new MagicAttackPoint(mat);
            Def = new DefensePoint(def);
            Mde = new MagicDefensePoint(mde);
        }

        // This constructor will be deleted.
        public CharacterParameter()
        {
            Name = "Default";
            Hp = new HealthPoint(100);
            Mp = new MagicPoint(100);
            Atk = new AttackPoint(10);
            Mat = new MagicAttackPoint(10);
            Def = new DefensePoint(10);
            Mde = new MagicDefensePoint(10);
        }

    }
}