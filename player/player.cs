using Godot;

public partial class player : CharacterBody2D
{
    public const float Speed = 100.0f;

    public override void _PhysicsProcess(double delta)
    {
        HandleInput();
        MoveAndSlide();
    }


    private void HandleInput()
    {
        var moveDirection = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
        Velocity = moveDirection * Speed;
    }
}
