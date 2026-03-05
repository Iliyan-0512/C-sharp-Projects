using Godot;
using System;

public partial class MainMenu : Control
{
	

	private VBoxContainer _menuContainer;
	
	private Control _howToPlayPanel;
	
	private Button _howToPlayCloseButton;
	private Label _howToPlayLabel;

	public override void _Ready()
	{
		// [translate:Кеширане на възлите]
		_menuContainer   = GetNode<VBoxContainer>("VBoxContainer");
		
		_howToPlayPanel  = GetNode<Control>("HowToPlayPanel");
		_howToPlayCloseButton = _howToPlayPanel.GetNode<Button>("CloseButton");
		_howToPlayLabel       = _howToPlayPanel.GetNode<Label>("Label");

		
		

		// [translate:Скриваме панелите в началото]
		
		_howToPlayPanel.Hide();

		// [translate:Бутони от главното меню]
		GetNode<Button>("VBoxContainer/StartButton").Pressed     += OnStartPressed;
		GetNode<Button>("VBoxContainer/HowToPlayButton").Pressed += OnHowToPlayPressed;
		
		GetNode<Button>("VBoxContainer/QuitButton").Pressed      += OnQuitPressed;

		// [translate:Бутон Close в HowToPlayPanel]
		_howToPlayCloseButton.Pressed += OnHowToPlayClosePressed;

		
		

		// [translate:Слайдър и чекбокс]
		
		
	}

	

	

	private void OnStartPressed()
	{
		GetTree().ChangeSceneToFile("res://Scenes/Level1.tscn"); // пътя смени при нужда[web:42]
	}

	private void OnHowToPlayPressed()
	{
		_menuContainer.Hide();     
		_howToPlayPanel.Show();    
	}

	private void OnHowToPlayClosePressed()
	{
		_howToPlayPanel.Hide();    
		_menuContainer.Show();     
	}

	

	

	private void OnQuitPressed()
	{
		GetTree().Quit();          
	}

	public override void _Process(double delta)
	{
	}
}
