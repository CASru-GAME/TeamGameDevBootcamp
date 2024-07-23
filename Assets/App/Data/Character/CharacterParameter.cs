using UnityEngine;

namespace App.Data
{
    public class CharacterParameter
    {
        public string Name { get; private set; }
        // TODO : パラメータのプロパティを設定する
        public HealthPoint hp;
        public MagicPoint mp;
        public AttackPoint Atk;
        public MagicAttackPoint Mat;
        public DefensePoint Def;
        public MagicDefensePoint Mde;
    }
}