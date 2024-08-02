using UnityEngine;
using App.Battle.Data;
using System;
using Unity.VisualScripting;


namespace App.Common.Data.MasterData
{
    [CreateAssetMenu(fileName = "BattleSkillData", menuName = "MasterData/BattleSkillData")]
    public class BattleSkillData : ScriptableObject
    {
        [field: SerializeField] public int Id { get; private set; }
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public int CnsMp { get; private set; }
        [field: SerializeField] public int AtkRate { get; private set; }
        [field: SerializeField] public int MatRate { get; private set; }
    }
}
