using TrueRogueliike.Components;

namespace TrueRogueliike.Core.Interfaces
{
    public interface IGameSceneReader
    {
        List<GameObject> GameObjects { get; }
        int Width { get; }
        int Height { get; }
        bool IsPositionFree(VectorPosition position);
        List<GameObject> GetObjectsAround(VectorPosition position);
        Dictionary<string, GameObject> GetFirstObjectsInEachDirection(VectorPosition position);
        GameObject? GetObjectAtPosition(VectorPosition position);
    }
}
