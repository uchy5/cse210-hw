public class Battle
{
    private readonly Player _player;
    private readonly Enemy _enemy;
    private readonly NPC _npc;

    public Battle(Player player, Enemy enemy, NPC npc)
    {
        _player = player;
        _enemy = enemy;
        _npc = npc;
    }

    public void Start()
    {
        Console.WriteLine("Battle begins!");
        DisplayCharacterInfo(); // Display initial info

        // Simulate battle rounds
        while (_player.Stats.IsAlive() && _enemy.Stats.IsAlive())
        {
            _player.Attack(_enemy);
            if (_enemy.Stats.IsAlive())
            {
                _npc.Attack(_enemy);
            }
            if (_enemy.Stats.IsAlive())
            {
                _enemy.Attack(_player);
            }
        }

        // Determine and display the outcome of the battle
        DisplayFinalResults();
    }

    private void DisplayCharacterInfo()
    {
        _player.DisplayInfo();
        _enemy.DisplayInfo();
        _npc.DisplayInfo();
    }

    private void DisplayFinalResults()
    {
        Console.WriteLine("\nBattle ended!");
        if (_player.Stats.IsAlive())
        {
            Console.WriteLine($"{_player.GetTitle()} wins!");
        }
        else
        {
            Console.WriteLine($"{_enemy.GetTitle()} wins!");
        }

        // Display final stats
        _player.DisplayInfo();
        _enemy.DisplayInfo();
        _npc.DisplayInfo();
    }
}
