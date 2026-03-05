using Godot;

public partial class Coin : Area2D
{
	public override void _Ready()
	{
		BodyEntered += OnBodyEntered;
	}

	private void OnBodyEntered(Node body)
	{
		if (body is Player)
		{
			var pd = (PlayerData)GetNode("/root/PlayerData");
			pd.Coins += 1;
			QueueFree();
		}
	}
}
