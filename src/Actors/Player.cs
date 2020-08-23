using Godot;

public class Player : Actor
{
       public override void _PhysicsProcess(float delta) {
            
            // Any time you override a method and want to call the parent method use this
            base._PhysicsProcess(delta);
       }
}