using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "InputReader", menuName = "Game/Input Reader")]
public class InputReader : ScriptableObject, GameInput.IGameplayActions, GameInput.ISpellbarActions
{
	// Assign delegate{} to events to initialise them with an empty delegate
	// so we can skip the null check when we use them

	// Gameplay
	public event UnityAction jumpEvent = delegate { };
	public event UnityAction<Vector2> moveEvent = delegate { };
	public event UnityAction<float> rotateEvent = delegate { };
	public event UnityAction<float> strafeEvent = delegate { };

	public event UnityAction<Vector2> lookEvent = delegate { };
	public event UnityAction<float> zoomEvent = delegate { };

	public event UnityAction<bool> rightButtonEvent = delegate { };

	public event UnityAction<int> useSpellEvent = delegate { };

	private GameInput gameInput;

	private void OnEnable()
	{
		if (gameInput == null)
		{
			gameInput = new GameInput();
			gameInput.Gameplay.SetCallbacks(this);
			gameInput.Spellbar.SetCallbacks(this);
		}
		EnableGameplayInput();
		EnableSpellbarInput();
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
		if (LeftMouseDown() || RightMouseDown())
			lookEvent.Invoke(context.ReadValue<Vector2>());
	}

	public void EnableGameplayInput()
	{
		gameInput.Gameplay.Enable();
	}

	public void EnableSpellbarInput()
    {
		gameInput.Spellbar.Enable();
    }

	public void DisableAllInput()
	{
		gameInput.Gameplay.Disable();
	}

	public bool LeftMouseDown() => Mouse.current.leftButton.isPressed;

	public bool RightMouseDown() => Mouse.current.rightButton.isPressed;

	public void OnZoomCamera(InputAction.CallbackContext context)
    {
		zoomEvent.Invoke(context.ReadValue<float>());
    }

    public void OnRightClick(InputAction.CallbackContext context)
    {
		rightButtonEvent.Invoke(context.phase == InputActionPhase.Performed);
    }

	private void HandleSpell(InputAction.CallbackContext context, int n)
    {
		if (context.phase == InputActionPhase.Performed)
        {
			useSpellEvent.Invoke(n);
		}
    }

    public void OnSpell1(InputAction.CallbackContext context)
    {
		HandleSpell(context, 1);
    }

    public void OnSpell2(InputAction.CallbackContext context)
    {
		HandleSpell(context, 2);
	}

    public void OnSpell3(InputAction.CallbackContext context)
    {
		HandleSpell(context, 3);
	}

    public void OnSpell4(InputAction.CallbackContext context)
    {
		HandleSpell(context, 4);
	}

    public void OnSpell5(InputAction.CallbackContext context)
    {
		HandleSpell(context, 5);
	}
}
