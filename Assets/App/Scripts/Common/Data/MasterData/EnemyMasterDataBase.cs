using UnityEngine;
using App.Common.Data;
using App.Battle.Data;

[CreateAssetMenu(fileName = "EnemyMasterDataBase", menuName = "MasterData/EnemyMasterDataBase")]

public class EnemyMasterDataBase : ScriptableObject
{
    [field: SerializeField] public EnemyMasterData[] EnemyMasterData { get; private set; }
}
