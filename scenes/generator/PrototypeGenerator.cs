using Godot;

// This script represents a control in the Godot scene, specifically designed to generate stardust.
public partial class PrototypeGenerator : Control
{
  // The current amount of stardust generated, initialized to 0.
  private int _stardust = 0;

  // Label that displays the current stardust amount.
  [Export]
  public Label label;

  // Button used for user interaction.
  [Export]
  public Button button;

  // Timer that triggers events at regular intervals.
  [Export]
  public Timer timer;

  // Called when the control is fully initialized and ready to use.
  public override void _Ready()
  {
	UpdateLabel();
  }

  // Method called when the button is pressed.
  public void OnButtonPressed()
  {
	timer.Start();
	button.Disabled = true;
  }

  // Method called when the timer times out (i.e., when the set time elapses).
  public void OnTimerTimeout()
  {
	GenerateStardust();
  }

  // Method responsible for incrementing the stardust amount and updating the label.
  private void GenerateStardust()
  {
	_stardust += 1;
	UpdateLabel();
  }

  // Method that updates the label text with the current stardust amount.
  private void UpdateLabel()
  {
	label.Text = $"Stardust: {_stardust}";
  }
}
