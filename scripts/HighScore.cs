using Godot;
using System;

public partial class HighScore : Label
{
	private GameManager gameManager;
	
	public override void _Ready()
	{
		gameManager = GetNode<GameManager>("%GameManager");
	}

	public override void _Process(double delta)
	{
		this.Text = $"Best: {gameManager.CurrentScore.ToString("D4")}M";
	}
}
