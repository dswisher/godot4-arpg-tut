using Godot;
using System;

public partial class Icon : Sprite2D
{
    private float moveBy = 1;

    public override void _Process(double delta)
    {
        moveBy += 0.01f;
        MoveLocalX(moveBy);
    }
}
