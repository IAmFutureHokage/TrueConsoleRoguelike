using TrueRogueliike.Core;

namespace TrueRogueliike.Components
{
    public class GameEnemy : GameObject
    {
        private readonly IGameSceneReader _sceneReader;
        public int Health { get; set; }

        public GameEnemy(char symbol, VectorPosition position, int health, IGameSceneReader sceneReader)
            : base(symbol, position)
        {
            Health = health;
            _sceneReader = sceneReader;
        }


        public virtual void Move(VectorPosition direction)
        {
            VectorPosition newPosition = Position + direction;

            if (_sceneReader.IsPositionFree(newPosition))
            {
                Position = newPosition;
            }
        }

        public virtual void TakeDamage(int damageAmount)
        {
            Health -= damageAmount;
        }
    }
}
