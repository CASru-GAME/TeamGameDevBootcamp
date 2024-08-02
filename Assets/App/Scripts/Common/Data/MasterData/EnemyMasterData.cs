using UnityEngine;
using App.Common.Data;
using System;
using Unity.VisualScripting;


namespace App.Common.Data.MasterData
{
    [CreateAssetMenu(fileName = "EnemyMasterData", menuName = "MasterData/EnemyMasterData")]
    public class EnemyMasterData : ScriptableObject, ISerializationCallbackReceiver
    {
        [field: SerializeField] public int Id { get; private set; }
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public int Hp { get; private set; }
        [field: SerializeField] public int Mp { get; private set; }
        [field: SerializeField] public int Atk { get; private set; }
        [field: SerializeField] public int Mat { get; private set; }
        [field: SerializeField] public int Def { get; private set; }
        [field: SerializeField] public int Mde { get; private set; }

        [field: NonSerialized] public CharacterParameter CharacterParameter { get; private set; }

        public void OnBeforeSerialize() { }
        public void OnAfterDeserialize()
        {
            CharacterParameter = new CharacterParameter(Name, Hp, Mp, Atk, Mat, Def, Mde);
        }
    }
}
