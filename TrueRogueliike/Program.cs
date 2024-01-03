using TrueRogueliike.Components;
using TrueRogueliike.Core;

class Program
{
    static void Main()
    {
        int width = 50; 
        int height = 20; 

        GameObjectFactory factory = new();
        GameScene scene = new(width, height, factory); 
        Player player = factory.CreatePlayer(new VectorPosition(1, 1), scene);
        PlayerController playerController = new(player);

        GameLoop gameLoop = new(scene, playerController); 
        
        gameLoop.Run(); 
    }
}
