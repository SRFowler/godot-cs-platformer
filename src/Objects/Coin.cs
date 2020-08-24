using Godot;
using System;

public class Coin : Area2D
{
    private AnimationPlayer animPlayer;
    public override void _Ready()
    {
       animPlayer = GetNode<AnimationPlayer>("AnimationPlayer"); 
    }

    private void OnBodyEntered(PhysicsBody2D body)
    {
        animPlayer.Play("fadeOut");
    }
}
