using Godot;

public class Player : Actor
{
    private Vector2 direction = new Vector2(0, 1);
    public override void _PhysicsProcess(float delta)
    {
        direction.x = Input.GetActionStrength("move_right") - Input.GetActionStrength("move_left");
        velocity = direction * speed;
        
        // Any time you override a method and want to call the parent method use this
        base._PhysicsProcess(delta);
    }
}