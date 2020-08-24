using Godot;

public class Actor : KinematicBody2D
{
    [Export]
    public int gravity = 1000;
    [Export]
    public Vector2 speed = new Vector2(800, 800);
    public Vector2 velocity = new Vector2(0, 0);
    protected Vector2 FloorNormal = Vector2.Up;
    

}