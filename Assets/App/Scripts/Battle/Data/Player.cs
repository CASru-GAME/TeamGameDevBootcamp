using App.Common.Data;

namespace App.Battle.Data
{
    public class Player
    {
        public string Id { get; }
        public CharacterParameter characterParameter { get; }
        public ExperiencePoint experiencePoint { get; }

        public Player(string id, CharacterParameter characterParameter, ExperiencePoint experiencePoint)
        {
            Id = id;
            this.characterParameter = characterParameter;
            this.experiencePoint = experiencePoint;
        }
    }
}