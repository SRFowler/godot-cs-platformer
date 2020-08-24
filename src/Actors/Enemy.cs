using Godot;

public class Enemy : Actor
{

    public override void _Ready()
    {
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
