using RPG_Game;
using RPG_Game.Enemies;
class Primary
{
    public static void Main(string[] args)
    {
        Enemy enemy = new Enemy(5, 25);
        enemy.Display();
    }
}