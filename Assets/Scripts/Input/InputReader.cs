using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "InputReader", menuName = "Game/Input Reader")]
public class InputReader : ScriptableObject, GameInput.IGameplayActions
{
	// Assign delegate{} to events to initialise them with an empty delegate
	// so we can skip the null check when we use them

	// Gameplay
	public event UnityAction jumpEvent = delegate { };
	public event UnityAction<Vector2> moveEvent = delegate { };
	public event UnityAction<float> rotateEvent = delegate { };
	public event UnityAction<float> strafeEvent = delegate { };

	public event UnityAction<Vector2> lookEvent = delegate { };

	private GameInput gameInput;

	private void OnEnable()
	{
		if (gameInput == null)
		{
			gameInput = new GameInput();
			gameInput.Gameplay.SetCallbacks(this);
		}

		EnableGameplayInput();
	}

	private void OnDisable()
	{
		DisableAllInput();
	}

	public void OnJump(InputAction.CallbackContext context)
	{
		if (context.phase == InputActionPhase.Performed)
			jumpEvent.Invoke();
	}

	public void OnMove(InputAction.CallbackContext context)
	{
		moveEvent.Invoke(context.ReadValue<Vector2>());
	}

	public void OnRotate(InputAction.CallbackContext context)
	{
		rotateEvent.Invoke(context.ReadValue<float>());
	}

	public void OnStrafe(InputAction.CallbackContext context)
	{
		strafeEvent.Invoke(context.ReadValue<float>());
	}

	public void OnLook(InputAction.CallbackContext context)
	{
		lookEvent.Invoke(context.ReadValue<Vector2>().normalized);
	}

	public void EnableGameplayInput()
	{
		gameInput.Gameplay.Enable();
	}

	public void DisableAllInput()
	{
		gameInput.Gameplay.Disable();
	}

	public bool LeftMouseDown() => Mouse.current.leftButton.isPressed;
}
