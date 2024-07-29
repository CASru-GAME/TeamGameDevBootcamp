using App.Battle.Data;
using App.Common.Data;
using App.Battle.Interfaces.Datastores;
using System;
using System.Linq;
using System.Collections.Generic;
using UniRx;

namespace App.Battle.Datastores
{
    public class BattleEnemyDatastore : IBattleEnemyDatastore, IDisposable
    {
        private Dictionary<string, Enemy> _enemies = new();
        public IEnumerable<Enemy> Enemies => _enemies.Values.ToArray();
        
        public void AddEnemy(string id, CharacterParameter characterParameter)
        {
            if(characterParameter == null)
            {
                throw new NullReferenceException($"{nameof(CharacterParameter)} is null");
            }

            var enemy = new Enemy(id, characterParameter);
            UnityEngine.Debug.Log($"{enemy} added");
            
            _enemies.Add(id, enemy);
        }
        
        public void RemoveEnemy(string id)
        {
            if(!_enemies.ContainsKey(id))
            {
                return;
            }
            _enemies.Remove(id);
        }

        public Enemy GetEnemyBy(string id)
        {
            if(!_enemies.ContainsKey(id))
            {
                return null;
            }

            var enemy = _enemies[id];
            UnityEngine.Debug.Log($"{enemy} got");            
            return enemy;
        }

        public void Dispose()
        {
            _enemies.Clear();
        }
    }
}