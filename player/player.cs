using Godot;

public partial class player : CharacterBody2D
{
    // TODO - how to make this visible in the inspector?
    private const float Speed = 50.0f;

    private AnimationPlayer animations;


    public override void _Ready()
    {
        animations = GetNode<AnimationPlayer>("AnimationPlayer");
    }


    public override void _PhysicsProcess(double delta)
    {
        HandleInput();
        MoveAndSlide();
        UpdateAnimation();
    }


    private void UpdateAnimation()
    {
        if (Velocity.Length() == 0)
        {
            animations.Stop();
        }
        else
        {
            var direction = "Down";
            if (Velocity.X < 0)
            {
                direction = "Left";
            }
            else if (Velocity.X > 0)
            {
                direction = "Right";
            }
            else if (Velocity.Y < 0)
            {
                direction = "Up";
            }

            animations.Play("walk" + direction);
        }
    }


    private void HandleInput()
    {
        var moveDirection = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
        Velocity = moveDirection * Speed;
    }
}
