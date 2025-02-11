using Godot;

/// <summary>
/// A control that displays and manages stardust count.
/// </summary>
public partial class PrototypeClicker : Control
{
	/// <summary>
	/// The current stardust count.
	/// </summary>
	private int _stardust = 0;

	/// <summary>
	/// Gets the label to display the stardust count on.
	/// </summary>
	[Export]
	public Label MyLabel { get; set; }

	/// <summary>
	/// Called when the node enters the scene tree for the first time.
	/// Updates the initial stardust count displayed on the label.
	/// </summary>
	public override void _Ready()
	{
		UpdateLabel();
	}

	/// <summary>
	/// Handles button press events. Increments the stardust count and updates the label accordingly.
	/// </summary>
	public void OnButtonPressed()
	{
		_stardust += 1;
		UpdateLabel();
	}

	/// <summary>
	/// Updates the label to display the current stardust count.
	/// </summary>
	private void UpdateLabel()
	{
		MyLabel.Text = $"Stardust: {_stardust}";
	}
}
