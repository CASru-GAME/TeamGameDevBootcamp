using UnityEngine;

namespace App.Common.Data
{
    public class CharacterParameter
    {
        public string Name { get; private set; }
        public HealthPoint Hp;
        public MagicPoint Mp;
        public AttackPoint Atk;
        public MagicAttackPoint Mat;
        public DefensePoint Def;
        public MagicDefensePoint Mde;
    }
}