using Godot;

public partial class GameOverUI : CanvasLayer
{
	public override void _Ready()
	{
		GetNode<Button>("ButtonPlayAgain").Pressed += OnRetryPressed;
		GetNode<Button>("ButtonExit").Pressed += OnQuitPressed;
		GD.Print("LEVEL1 READY");
	}

	private void OnRetryPressed()
	{
		var pd = (PlayerData)GetNode("/root/PlayerData");

		pd.ResetForNewRun();
		GetTree().ChangeSceneToFile("res://Scenes/Level1.tscn");
	}

	private void OnQuitPressed()
	{
		GetTree().Quit();
	}
}
