using UnityEngine;

namespace App.Data
{
    public class CharacterParameter
    {
        public string Name { get; private set; }
        // TODO : パラメータのプロパティを設定する
        AttackPoint Atk;
        MagicAttackPoint Mat;
        DefensePoint Def;
        MagicDefensePoint Mde;
    }
}