namespace TrueRogueliike.Components
{
    public class GameObject
    {
        public char Symbol { get; set; }
        public VectorPosition Position { get; set; }

        public GameObject(char symbol, VectorPosition position)
        {
            Symbol = symbol;
            Position = position;
        }

        public virtual void Update()
        {
        }
    }
}