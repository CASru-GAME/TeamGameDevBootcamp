using App.Common.Data;

namespace App.Battle.Data
{
    public class Player
    {
        public string Id { get; }
        public CharacterParameter characterParameter { get; }

        public Player(string id, CharacterParameter characterParameter)
        {
            Id = id;
            this.characterParameter = characterParameter;
        }
    }
}