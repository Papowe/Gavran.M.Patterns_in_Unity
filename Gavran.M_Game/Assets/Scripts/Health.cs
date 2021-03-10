namespace Asteroid
{
    public class Health
    {
        public float Max { get; }
        public float Curent { get; private set; }

        public Health(float max, float curent)
        {
            Max = max;
            Curent = curent;
        }

        public void ChangeCurrentHealth(float hp)
        {
            Curent = hp;
        }
    }
}