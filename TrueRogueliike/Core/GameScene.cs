using TrueRogueliike.Components;

namespace TrueRogueliike.Core
{
    public class GameScene : IGameSceneReader, IGameSceneEditor
    {
        public List<GameObject> GameObjects { get; private set; }

        public int Width { get; private set; }
        public int Height { get; private set; }

        private readonly GameObjectFactory _factory;

        public GameScene(int width, int height, GameObjectFactory factory)
        {
            Width = width;
            Height = height;
            GameObjects = new List<GameObject>(width * height);
            _factory = factory;

            _factory.OnGameObjectCreated += AddGameObject;

            Init();
        }

        private void Init()
        {
            GameObjects.Clear();
            MazeGenerator generator = new(_factory, Width, Height);
            generator.GenerateMaze();
        }

        public void Finished()
        {
            var player = GameObjects.OfType<Player>().FirstOrDefault();
            
            Init();

            if (player != null)
            {
                player.Position = new VectorPosition(1, 1);
                player.Health += 10;
                GameObjects.Add(player);
            }
        }

        public void AddGameObject(GameObject gameObject)
        {
            if (GameObjects.Any(obj => obj != null && obj.Position.X == gameObject.Position.X && obj.Position.Y == gameObject.Position.Y))
            {
                throw new InvalidOperationException("Position is already occupied.");
            }

            GameObjects.Add(gameObject);
        }

        public void RemoveGameObject(GameObject gameObject) 
        {
            GameObjects.Remove(gameObject);
        }

        public bool IsPositionFree(VectorPosition position)
        {
            return !GameObjects.Any(gameObject => gameObject.Position.Equals(position));
        }

        public void Unsubscribe()
        {
            _factory.OnGameObjectCreated -= AddGameObject;
        }
    }
}
