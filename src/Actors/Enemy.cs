using Godot;

public class Enemy : Actor
{

    private void OnStompDetectorBodyEntered(PhysicsBody2D body)
    {
        if(body.GlobalPosition.y > GetNode<Area2D>("StompDetector").GlobalPosition.y)
        {
            return;
        }
        //GetNode<CollisionShape2D>("CollisionShape2D").Disabled = true;
        QueueFree();
    }

    public override void _Ready()
    {
        SetPhysicsProcess(false);
        velocity.x = -speed.x;
    }

    public override void _PhysicsProcess(float delta)
    {
        velocity.y += gravity * delta;

        if(IsOnWall()) 
        {
            velocity.x *= -1;
        }
        velocity.y = MoveAndSlide(velocity, FloorNormal).y;
    }
}