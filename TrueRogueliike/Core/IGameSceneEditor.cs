using TrueRogueliike.Components;

namespace TrueRogueliike.Core
{
    public interface IGameSceneEditor
    {
        List<GameObject> GameObjects { get; }
        int Width { get; }
        int Height { get; }
        void Finished();
        void AddGameObject(GameObject gameObject);
        void RemoveGameObject(GameObject gameObject);
        void Unsubscribe();
    }
}
