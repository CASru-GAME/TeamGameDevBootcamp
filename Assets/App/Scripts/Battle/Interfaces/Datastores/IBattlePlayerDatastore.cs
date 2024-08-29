using App.Battle.Data;
using App.Common.Data;
using System.Collections.Generic;

namespace App.Battle.Interfaces.Datastores
{
    public interface IBattlePlayerDatastore
    {
        IEnumerable<Player> Players { get; }
        void AddPlayer(string id, CharacterParameter characterParameter, ExperiencePoint experiencePoint);
        void RemovePlayer(string id);
        Player GetPlayerBy(string id);
    }
}