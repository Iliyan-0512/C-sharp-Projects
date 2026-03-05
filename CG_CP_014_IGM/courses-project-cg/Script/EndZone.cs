using Godot;
using System.Threading.Tasks;

public partial class EndZone : Area2D
{
	[Export] public string NextScenePath = "res://Scenes/Level2.tscn";
	[Export] public int TotalCoinsInLevel = 6;

	private Label _msgLabel;

	public override void _Ready()
	{
		BodyEntered += OnBodyEntered;
		_msgLabel = GetNode<Label>("../MessageLayer/MessageLabel");
		_msgLabel.Visible = false;
	}

	private async void OnBodyEntered(Node2D body)
	{
		if (body is Player)
		{
			var playerData = (PlayerData)GetNode("/root/PlayerData");

			if (playerData.Coins >= TotalCoinsInLevel)
			{
				GetTree().ChangeSceneToFile(NextScenePath);
			}
			else
			{
				GD.Print("Не си събрал всички монети!");

				_msgLabel.Text = "Collect all coins to exit!";
				_msgLabel.Visible = true;

				
				await ToSignal(GetTree().CreateTimer(3.0f), "timeout");
				_msgLabel.Visible = false;
			}
		}
	}
}
