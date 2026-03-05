using Godot;

public partial class GemPickup : Area2D
{
	[Export] public int GemValue = 1;

	public override void _Ready()
	{
		BodyEntered += OnBodyEntered;
	}

	private void OnBodyEntered(Node2D body)
	{
		if (body is not Player) return;

		var playerData = (PlayerData)GetNode("/root/PlayerData");
		playerData.Gems += GemValue;

		QueueFree();
	}
}
