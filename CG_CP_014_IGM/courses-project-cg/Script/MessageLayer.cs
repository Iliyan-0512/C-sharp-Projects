using Godot;

public partial class MessageLayer : CanvasLayer
{
	private Label _messageLabel;
	

	public override void _Ready()
	{
		

	_messageLabel = GetNode<Label>("MessageLabel");
	_messageLabel.Visible = true;

	var timer = GetTree().CreateTimer(3.5);
	timer.Timeout += () => _messageLabel.Visible = false;


	}
	
	
}

	
