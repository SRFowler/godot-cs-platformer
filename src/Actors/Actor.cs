using Godot;

public class Actor : KinematicBody2D
{
    [Export]
    private int gravity = 1000;
    [Export]
    public Vector2 speed = new Vector2(300, 1000);

    public Vector2 velocity = new Vector2(0, 0);
    
    public override void _PhysicsProcess(float delta) {
        velocity.y += gravity * delta;
        velocity = MoveAndSlide(velocity);
    }
}