using App.Common.Data;

namespace App.Battle.Data
{
    public class Enemy
    {
        public string Id { get; }
        public CharacterParameter characterParameter { get; }

        public Enemy(string id, CharacterParameter characterParameter)
        {
            Id = id;
            this.characterParameter = characterParameter;
        }
    }
}