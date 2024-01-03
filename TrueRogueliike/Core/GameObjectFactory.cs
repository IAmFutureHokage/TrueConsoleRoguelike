using TrueRogueliike.Components;

namespace TrueRogueliike.Core
{
    public class GameObjectFactory
    {
       
        public delegate void GameObjectCreatedHandler(GameObject gameObject);

        public event GameObjectCreatedHandler OnGameObjectCreated = delegate { };

        public Player CreatePlayer(VectorPosition position, IGameSceneReader sceneReader)
        {
            var player = new Player('P', position, 50, sceneReader);
            OnGameObjectCreated?.Invoke(player);
            return player;
        }

        public void CreateWarrior(VectorPosition position, IGameSceneReader sceneReader)
        {
            var warrior = new Warrior('W', position, 100, sceneReader);
            OnGameObjectCreated?.Invoke(warrior);
        }

        public void CreateArcher(VectorPosition position, IGameSceneReader sceneReader)
        {
            var archer = new Archer('A', position, 80, sceneReader);
            OnGameObjectCreated?.Invoke(archer);
        }

        public void CreateWall(VectorPosition position)
        {
            var wall = new GameObject('#', position);
            OnGameObjectCreated?.Invoke(wall);
        }
    }

}
