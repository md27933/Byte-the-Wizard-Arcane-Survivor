using Godot;

public partial class Home : Control
{
	public override void _Ready()
	{
		GetNode<Button>("Start").Pressed += StartGame;
	}

	private void StartGame()
	{
		GetTree().ChangeSceneToFile("res://Scenes/Game.tscn");
	}
}
