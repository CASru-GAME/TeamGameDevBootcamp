using App.Battle.Data;
using App.Common.Data;
using App.Battle.Interfaces.Datastores;
using System;
using System.Linq;
using System.Collections.Generic;
using UniRx;

namespace App.Battle.Datastores
{
    public class BattlePlayerDatastore : IBattlePlayerDatastore, IDisposable
    {
        private Dictionary<string, Player> _players = new();
        public IEnumerable<Player> Players => _players.Values.ToArray();

        public void AddPlayer(string id, CharacterParameter characterParameter)
        {
            if(characterParameter == null)
            {
                throw new NullReferenceException($"{nameof(CharacterParameter)} is null");
            }

            var player = new Player(id, characterParameter);
            UnityEngine.Debug.Log($"{player} added");

            _players.Add(id, player);
        }

        public void RemovePlayer(string id)
        {
            if(!_players.ContainsKey(id))
            {
                return;
            }
            _players.Remove(id);
        }

        public Player GetPlayerBy(string id)
        {
            if(!_players.ContainsKey(id))
            {
                return null;
            }

            var player = _players[id];
            UnityEngine.Debug.Log($"{player} got");
            return player;
        }

        public void Dispose()
        {
            _players.Clear();
        }
    }
}