using Godot;

public partial class HealthUI : CanvasLayer
{
	private PlayerData _pd;
	private Label _label;

	public override void _Ready()
	{
		_label = GetNode<Label>("HealthLabel"); // сложи правилното име
		_pd = (PlayerData)GetNode("/root/PlayerData");

		TreeExiting += OnTreeExiting;

		_pd.HealthChanged += OnHealthChanged;
		OnHealthChanged(_pd.Health);
	}

	private void OnTreeExiting()
	{
		if (_pd != null) _pd.HealthChanged -= OnHealthChanged;
	}

	private void OnHealthChanged(int hp)
	{
		if (!IsInsideTree()) return;
		_label.Text = "HP: " + hp;
	}
}
