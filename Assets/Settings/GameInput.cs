// GENERATED AUTOMATICALLY FROM 'Assets/Settings/GameInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInput"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""a5e54285-42ae-4274-8ef7-ef7160cc7f86"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""ce0ae9eb-e515-4c98-abbf-82199deab5da"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8e40fa78-d06c-43d3-81b7-9c47ab9e6cba"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""9aa046f6-55fd-4fef-ae56-693de4df64af"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""83e74315-5d26-4efe-9636-212773800c93"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ZoomCamera"",
                    ""type"": ""Value"",
                    ""id"": ""874e2995-178f-4106-abde-5fe40f4ce2ed"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""Button"",
                    ""id"": ""f5b05e0e-f559-4865-9e64-0c8c256d4460"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""07f1ff97-b2da-4c70-9ef4-6c32befa36e4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""92c50087-1cb6-49b6-a95b-44553fb5b297"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WQSE"",
                    ""id"": ""e4b162e0-52b0-4b6c-8658-c2c81cd9f004"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""710300fe-449d-4577-a81e-90310be4b4c8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""05449e59-5197-4b1d-9fdb-2b74ad71b51a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""a3ce5699-25e0-4970-9559-9af9f9f1d73e"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""8df1f9e6-9522-4e9d-862b-7a19864b2390"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""e0befa68-b169-487b-8115-8c36cd0bb4eb"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3dec5091-d815-49e5-93f8-1a77a99d839b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""43ed02bb-353b-413e-b8da-bcd32a2a5a5d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7cf66053-b040-4046-a939-9c8606c3a585"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(min=-0.02,max=0.02)"",
                    ""groups"": """",
                    ""action"": ""ZoomCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee62de31-4ad4-47a6-bc53-04095723dba1"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Spellbar"",
            ""id"": ""af80cc93-ef98-421c-ae70-5854ac7f381e"",
            ""actions"": [
                {
                    ""name"": ""Spell1"",
                    ""type"": ""Button"",
                    ""id"": ""0761f99f-14ac-4cd8-889d-0183efd62b1d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Spell2"",
                    ""type"": ""Button"",
                    ""id"": ""e0675ce7-4920-43b4-9a64-3149f895aca1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Spell3"",
                    ""type"": ""Button"",
                    ""id"": ""2d91cc42-639a-4f70-aaf6-6595dcf75bfd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Spell4"",
                    ""type"": ""Button"",
                    ""id"": ""fbdff8f7-71cf-492e-ae35-67c42c05c670"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Spell5"",
                    ""type"": ""Button"",
                    ""id"": ""af708d65-f4aa-4b6a-b224-fe20b334eb09"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3382b757-2137-47c9-b3f3-062b21a1daf9"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spell1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b425f8e-4ca0-4963-ade2-edb7012b19e1"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spell2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84318341-f4dc-4d2d-bfc1-e08e0c5ce53a"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spell3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d25951c7-aa25-4ab1-91ee-bbfadd0dda3c"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spell4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4abcc8f8-d488-4e70-8c1c-f6aeb18ea7bd"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spell5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay_Look = m_Gameplay.FindAction("Look", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Rotate = m_Gameplay.FindAction("Rotate", throwIfNotFound: true);
        m_Gameplay_ZoomCamera = m_Gameplay.FindAction("ZoomCamera", throwIfNotFound: true);
        m_Gameplay_RightClick = m_Gameplay.FindAction("RightClick", throwIfNotFound: true);
        // Spellbar
        m_Spellbar = asset.FindActionMap("Spellbar", throwIfNotFound: true);
        m_Spellbar_Spell1 = m_Spellbar.FindAction("Spell1", throwIfNotFound: true);
        m_Spellbar_Spell2 = m_Spellbar.FindAction("Spell2", throwIfNotFound: true);
        m_Spellbar_Spell3 = m_Spellbar.FindAction("Spell3", throwIfNotFound: true);
        m_Spellbar_Spell4 = m_Spellbar.FindAction("Spell4", throwIfNotFound: true);
        m_Spellbar_Spell5 = m_Spellbar.FindAction("Spell5", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Jump;
    private readonly InputAction m_Gameplay_Look;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Rotate;
    private readonly InputAction m_Gameplay_ZoomCamera;
    private readonly InputAction m_Gameplay_RightClick;
    public struct GameplayActions
    {
        private @GameInput m_Wrapper;
        public GameplayActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputAction @Look => m_Wrapper.m_Gameplay_Look;
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Rotate => m_Wrapper.m_Gameplay_Rotate;
        public InputAction @ZoomCamera => m_Wrapper.m_Gameplay_ZoomCamera;
        public InputAction @RightClick => m_Wrapper.m_Gameplay_RightClick;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Look.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Rotate.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
                @ZoomCamera.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZoomCamera;
                @ZoomCamera.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZoomCamera;
                @ZoomCamera.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZoomCamera;
                @RightClick.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightClick;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @ZoomCamera.started += instance.OnZoomCamera;
                @ZoomCamera.performed += instance.OnZoomCamera;
                @ZoomCamera.canceled += instance.OnZoomCamera;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Spellbar
    private readonly InputActionMap m_Spellbar;
    private ISpellbarActions m_SpellbarActionsCallbackInterface;
    private readonly InputAction m_Spellbar_Spell1;
    private readonly InputAction m_Spellbar_Spell2;
    private readonly InputAction m_Spellbar_Spell3;
    private readonly InputAction m_Spellbar_Spell4;
    private readonly InputAction m_Spellbar_Spell5;
    public struct SpellbarActions
    {
        private @GameInput m_Wrapper;
        public SpellbarActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Spell1 => m_Wrapper.m_Spellbar_Spell1;
        public InputAction @Spell2 => m_Wrapper.m_Spellbar_Spell2;
        public InputAction @Spell3 => m_Wrapper.m_Spellbar_Spell3;
        public InputAction @Spell4 => m_Wrapper.m_Spellbar_Spell4;
        public InputAction @Spell5 => m_Wrapper.m_Spellbar_Spell5;
        public InputActionMap Get() { return m_Wrapper.m_Spellbar; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SpellbarActions set) { return set.Get(); }
        public void SetCallbacks(ISpellbarActions instance)
        {
            if (m_Wrapper.m_SpellbarActionsCallbackInterface != null)
            {
                @Spell1.started -= m_Wrapper.m_SpellbarActionsCallbackInterface.OnSpell1;
                @Spell1.performed -= m_Wrapper.m_SpellbarActionsCallbackInterface.OnSpell1;
                @Spell1.canceled -= m_Wrapper.m_SpellbarActionsCallbackInterface.OnSpell1;
                @Spell2.started -= m_Wrapper.m_SpellbarActionsCallbackInterface.OnSpell2;
                @Spell2.performed -= m_Wrapper.m_SpellbarActionsCallbackInterface.OnSpell2;
                @Spell2.canceled -= m_Wrapper.m_SpellbarActionsCallbackInterface.OnSpell2;
                @Spell3.started -= m_Wrapper.m_SpellbarActionsCallbackInterface.OnSpell3;
                @Spell3.performed -= m_Wrapper.m_SpellbarActionsCallbackInterface.OnSpell3;
                @Spell3.canceled -= m_Wrapper.m_SpellbarActionsCallbackInterface.OnSpell3;
                @Spell4.started -= m_Wrapper.m_SpellbarActionsCallbackInterface.OnSpell4;
                @Spell4.performed -= m_Wrapper.m_SpellbarActionsCallbackInterface.OnSpell4;
                @Spell4.canceled -= m_Wrapper.m_SpellbarActionsCallbackInterface.OnSpell4;
                @Spell5.started -= m_Wrapper.m_SpellbarActionsCallbackInterface.OnSpell5;
                @Spell5.performed -= m_Wrapper.m_SpellbarActionsCallbackInterface.OnSpell5;
                @Spell5.canceled -= m_Wrapper.m_SpellbarActionsCallbackInterface.OnSpell5;
            }
            m_Wrapper.m_SpellbarActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Spell1.started += instance.OnSpell1;
                @Spell1.performed += instance.OnSpell1;
                @Spell1.canceled += instance.OnSpell1;
                @Spell2.started += instance.OnSpell2;
                @Spell2.performed += instance.OnSpell2;
                @Spell2.canceled += instance.OnSpell2;
                @Spell3.started += instance.OnSpell3;
                @Spell3.performed += instance.OnSpell3;
                @Spell3.canceled += instance.OnSpell3;
                @Spell4.started += instance.OnSpell4;
                @Spell4.performed += instance.OnSpell4;
                @Spell4.canceled += instance.OnSpell4;
                @Spell5.started += instance.OnSpell5;
                @Spell5.performed += instance.OnSpell5;
                @Spell5.canceled += instance.OnSpell5;
            }
        }
    }
    public SpellbarActions @Spellbar => new SpellbarActions(this);
    public interface IGameplayActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnZoomCamera(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
    }
    public interface ISpellbarActions
    {
        void OnSpell1(InputAction.CallbackContext context);
        void OnSpell2(InputAction.CallbackContext context);
        void OnSpell3(InputAction.CallbackContext context);
        void OnSpell4(InputAction.CallbackContext context);
        void OnSpell5(InputAction.CallbackContext context);
    }
}
