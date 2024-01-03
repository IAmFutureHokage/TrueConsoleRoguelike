using TrueRogueliike.Core;

namespace TrueRogueliike.Components
{
    public sealed class Player : GameEnemy
    {

        public Player(char symbol, VectorPosition position, int health, IGameSceneReader sceneReader)
             : base(symbol, position, health, sceneReader)
        {

        }

        public override void Update()
        {
            base.Update();
        }
    }
}