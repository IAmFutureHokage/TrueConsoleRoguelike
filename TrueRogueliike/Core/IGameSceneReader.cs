using TrueRogueliike.Components;

namespace TrueRogueliike.Core
{
    public interface IGameSceneReader
    {
        List<GameObject> GameObjects { get; }
        int Width { get; }
        int Height { get; }
        bool IsPositionFree(VectorPosition position);
    }

}
