using Godot;
using System;

[Tool]
public class Portal2D : Area2D
{
    [Export]
    PackedScene nextScene;

    private AnimationPlayer animPlayer;

    private void OnBodyEntered(PhysicsBody2D body)
    {
        Teleport();
    }

    public override void _Ready()
    {
        animPlayer = GetNode<AnimationPlayer>("AnimationPlayer");
    }

    public override string _GetConfigurationWarning()
    {
        return nextScene == null ? "The Next Scene porperty can not be empty." : "";
    }

    async private void Teleport()
    {
        animPlayer.Play("fadeIn");
        await ToSignal(animPlayer, "animation_finished");
        GetTree().ChangeSceneTo(nextScene);
    }
}
