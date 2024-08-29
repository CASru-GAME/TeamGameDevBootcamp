using UnityEngine;
using App.Common.Data.MasterData;

namespace App.Common.Data.MasterData
{
    [CreateAssetMenu(fileName = "PlayerMasterDataBase", menuName = "MasterData/PlayerMasterDataBase")]

    public class PlayerMasterDataBase : ScriptableObject
    {
        [field: SerializeField] public PlayerMasterData[] PlayerMasterData { get; private set; }
    }
}
