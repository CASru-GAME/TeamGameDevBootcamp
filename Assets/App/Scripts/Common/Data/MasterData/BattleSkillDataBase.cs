using UnityEngine;

namespace App.Common.Data.MasterData
{
    [CreateAssetMenu(fileName = "BattleSkillDataBase", menuName = "MasterData/BattleSkillDataBase")]

    public class BattleSkillDataBase : ScriptableObject
    {
        [field: SerializeField] public BattleSkillData[] BattleSkillData { get; private set; }
    }
}