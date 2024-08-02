using UnityEngine;
using App.Common.Data.MasterData;

namespace App.Common.Data.MasterData
{
    [CreateAssetMenu(fileName = "EnemyMasterDataBase", menuName = "MasterData/EnemyMasterDataBase")]

    public class EnemyMasterDataBase : ScriptableObject
    {
        [field: SerializeField] public EnemyMasterData[] EnemyMasterData { get; private set; }
    }
}
