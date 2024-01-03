using TrueRogueliike.Components;

namespace TrueRogueliike.Core
{
    public class GameUpdater
    {
        private readonly IGameSceneEditor _scene;
        private bool _levelCompleted = false;

        public GameUpdater(IGameSceneEditor scene)
        {
            _scene = scene;
        }

        public void Update(ref bool isRunning)
        {
            var toRemove = new List<GameObject>();

            foreach (var gameObject in _scene.GameObjects)
            {
                gameObject.Update();

                if (gameObject is GameEnemy enemy && enemy.Health < 1)
                {
                    toRemove.Add(enemy);
                }

                if (gameObject is Player player)
                {
                    if (player.Health < 1) 
                    {
                        isRunning = false;
                    }

                    if (player.Position.X == _scene.Width - 2 && player.Position.Y == _scene.Height - 2)
                    {
                        _levelCompleted = true;
                    }
                }
            }

            foreach (var gameObject in toRemove)
            {
                _scene.RemoveGameObject(gameObject);
            }

            if (_levelCompleted)
            {
                _scene.Finished();
                _levelCompleted = false;
            }
        }
    }

}
