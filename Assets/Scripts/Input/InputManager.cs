using UnityEngine;

public class InputManager
{
    private InputControls inputControls;

    //public Vector2 inputDirection => inputControls.Player.Move.ReadValue<Vector2>();
    //Igual ao Seguinte Método \/ 🫗
    public Vector2 GetInputDirection()
    {
        return inputControls.Player.Move.ReadValue<Vector2>();
    }
    public InputManager()
    {
        inputControls = new InputControls();
        inputControls.Enable();
    }
    public void DisableInput() => inputControls.Disable();
}
