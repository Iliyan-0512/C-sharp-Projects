using Godot;

public partial class ShopArea : Area2D
{
	[Export] public int GemsPerPack = 10;
	[Export] public int HealthPerPack = 10;
	[Export] public int MaxHealth = 100;

	private bool _playerInside;

	private Control _shopPanel;
	private Label _gemsLabel;
	private Button _buyButton;
	private Button _closeButton;
	private Label _labelQ;

	private PlayerData _playerData;

	// Свойство, което Level1 използва
	public bool PlayerInside => _playerInside;

	public override void _Ready()
	{
		_playerData = (PlayerData)GetNode("/root/PlayerData");

		// ShopPanel e под CanvasLayer в root сцената
		_shopPanel   = GetNode<Control>("../CanvasLayer/ShopPanel");
		_gemsLabel   = _shopPanel.GetNode<Label>("GemsLabel");
		_buyButton   = _shopPanel.GetNode<Button>("BuyButton");
		_closeButton = _shopPanel.GetNode<Button>("CloseButton");

		_labelQ = GetNode<Label>("../CanvasLayer/LabelQ");

		_shopPanel.Hide();
		_labelQ.Hide();

		BodyEntered += body =>
		{
			if (body is Player)
			{
				_playerInside = true;
				_labelQ.Text = "Enter Q for store";
				_labelQ.Show();
			}
		};

		BodyExited += body =>
		{
			if (body is Player)
			{
				_playerInside = false;
				_shopPanel.Hide();
				_labelQ.Hide();
			}
		};

		_buyButton.Pressed += OnBuyPressed;
		_closeButton.Pressed += OnClosePressed;
	}

	private void OnClosePressed()
	{
		_shopPanel.Hide();
		if (_playerInside)
			_labelQ.Show();
	}

	private void OnBuyPressed()
	{
		if (_playerData.Gems >= GemsPerPack && _playerData.Health < MaxHealth)
		{
			_playerData.Gems -= GemsPerPack;
			_playerData.Health = Mathf.Min(MaxHealth, _playerData.Health + HealthPerPack);
			UpdateShopUI();
		}
		else
		{
			GD.Print("Not enough gems or already at max health.");
		}
	}

	public void SetHintVisible(bool visible)
	{
		if (visible && _playerInside)
			_labelQ.Show();
		else
			_labelQ.Hide();
	}

	private void UpdateShopUI()
	{
		_gemsLabel.Text = $"Gems: {_playerData.Gems}";
	}
}
