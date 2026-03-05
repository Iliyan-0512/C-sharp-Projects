using Godot;

public partial class DeathZone : Area2D
{
	public override void _Ready()
	{
		BodyEntered += OnDeathZoneBodyEntered;
	}

	private void OnDeathZoneBodyEntered(Node2D body)
	{
		if (body is Player)
		{
			var pd = (PlayerData)GetNode("/root/PlayerData");
			pd.Health = 0;

			CallDeferred(nameof(GoGameOver));
		}
	}

	private void GoGameOver()
	{
		GetTree().ChangeSceneToFile("res://Scenes/GameOver.tscn");
	}
}
