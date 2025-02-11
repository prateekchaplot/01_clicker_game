using Godot;

// A control that displays and manages stardust count.
public partial class PrototypeClicker : Control
{
	// The current stardust count.
	private int _stardust = 0;

	// Gets the label to display the stardust count on.
	[Export]
	public Label label;

	public override void _Ready()
	{
		UpdateLabel();
	}

	// Handles button press events to increment the stardust count.
	public void OnButtonPressed()
	{
		_stardust += 1;
		UpdateLabel();
	}

	// Updates the text of the label to display the current stardust count.
	private void UpdateLabel()
	{
		label.Text = $"Stardust: {_stardust}";
	}
}
