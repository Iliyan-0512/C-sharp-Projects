using Godot;
using System;

public partial class WinScreenUI : CanvasLayer
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GetNode<Button>("ButtonPlayAgain").Pressed += OnRetryPressed;
	GetNode<Button>("ButtonExit").Pressed += OnQuitPressed;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
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
