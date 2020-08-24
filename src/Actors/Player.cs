using Godot;

public class Player : Actor
{
 
     public override void _PhysicsProcess(float delta)
    {
        bool isJumpInterrupted = Input.IsActionJustReleased("jump") & velocity.y < 0.0;
        Vector2 direction = GetDirection();

        velocity = CalculateMoveVelocity(velocity, direction, speed, isJumpInterrupted);
        velocity = MoveAndSlide(velocity, FloorNormal);

        // Any time you override a method and want to call the parent method use this
        // base._PhysicsProcess(delta);
    }

     private Vector2 GetDirection()
     {
          /// Returns a new Vector2 with both properties as floats from -1 to 1
          return new Vector2(
               Input.GetActionStrength("move_right") - Input.GetActionStrength("move_left"),
               Input.IsActionJustPressed("jump") & IsOnFloor() ? -1 : 1
          );
     }

     private Vector2 CalculateMoveVelocity(
          Vector2 linearVelocity, 
          Vector2 direction,
          Vector2 speed,
          bool isJumpInterrupted)
     {
          Vector2 newVelocity = velocity;
          newVelocity.x = speed.x * direction.x;
          newVelocity.y += gravity * GetPhysicsProcessDeltaTime();
          if (direction.y == -1.0)
          {
               newVelocity.y = speed.y * direction.y;
          }

          if (isJumpInterrupted)
          {
               newVelocity.y = 0;
          }
          return newVelocity;
     }
}
