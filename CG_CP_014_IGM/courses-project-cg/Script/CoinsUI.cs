using Godot;

public partial class CoinsUI : CanvasLayer
{
	private PlayerData _pd;
	private Label _label;

	public override void _Ready()
	{
		_label = GetNode<Label>("Label");
		_pd = (PlayerData)GetNode("/root/PlayerData");

		// Важно: отписване при излизане
		TreeExiting += OnTreeExiting;

		_pd.CoinsChanged += OnCoinsChanged;
		OnCoinsChanged(_pd.Coins);
	}

	private void OnTreeExiting()
	{
		if (_pd != null) _pd.CoinsChanged -= OnCoinsChanged;
	}

	private void OnCoinsChanged(int coins)
	{
		if (!IsInsideTree()) return;   
		_label.Text = "Coins: " + coins;
	}
}
