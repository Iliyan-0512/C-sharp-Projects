using Godot;

public partial class Level1 : Node2D
{
	[Export] public int StartSeconds = 60;
	[Export] public string GameOverScene = "res://Scenes/GameOver.tscn";

	private int _secondsLeft;
	private Label _timeLabel;
	private Timer _timer;
	private Control _shopPanel;
	private ShopArea _shopArea;

	public override void _Ready()
	{
		// Този node да получава input и когато играта е паузната
		ProcessMode = ProcessModeEnum.Always;

		_secondsLeft = StartSeconds;

		_timeLabel = GetNode<Label>("CanvasLayerTimer/TimeLabel");
		_timer = GetNode<Timer>("CanvasLayerTimer/LevelTimer");

		// Shop UI
		_shopPanel = GetNode<Control>("CanvasLayer/ShopPanel");
		_shopPanel.Visible = false;
		_shopPanel.ProcessMode = ProcessModeEnum.WhenPaused;

		// ShopArea (по дървото ти: директно под root Node2D)
		_shopArea = GetNode<ShopArea>("ShopArea");

		// Таймерът да спира при pause
		_timer.ProcessMode = ProcessModeEnum.Pausable;

		UpdateLabel();

		_timer.Timeout += OnTimerTimeout;
		_timer.Start();
	}

	public override void _Input(InputEvent @event)
	{
		if (@event.IsActionPressed("shop_toggle"))
		{
			// Отваряме/затваряме шопа само ако играчът е в зоната
			if (_shopArea == null || !_shopArea.PlayerInside)
				return;

			bool shopOpen = !GetTree().Paused;

			GetTree().Paused = shopOpen;
			_shopPanel.Visible = shopOpen;

			// по желание – скриваме подсказката, докато е отворен шопа
			_shopArea.SetHintVisible(!shopOpen);
		}
	}

	private void OnTimerTimeout()
	{
		_secondsLeft--;
		UpdateLabel();

		if (_secondsLeft <= 0)
		{
			_timer.Stop();
			GetTree().Paused = false;
			GetTree().ChangeSceneToFile(GameOverScene);
		}
	}

	private void UpdateLabel()
	{
		_timeLabel.Text = $"Time: {_secondsLeft}";
	}
}
