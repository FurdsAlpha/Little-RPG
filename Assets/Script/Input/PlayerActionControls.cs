// GENERATED AUTOMATICALLY FROM 'Assets/Script/Input/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActionControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActionControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Combat"",
            ""id"": ""5b88a711-3a0e-4c51-b929-818e5f648885"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""d0b3b408-beec-4f38-b831-8b34d7b86c0d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attaque"",
                    ""type"": ""Button"",
                    ""id"": ""9cb39077-5bc0-46ac-be22-dd2d72761e77"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Esquive"",
                    ""type"": ""Button"",
                    ""id"": ""a30120f7-4edb-4a71-a320-563430524abc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttaqueLourde"",
                    ""type"": ""Button"",
                    ""id"": ""b944d875-fff1-4359-a811-24514184dde9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttaqueRapide"",
                    ""type"": ""Button"",
                    ""id"": ""4b08826c-5a51-4144-bcf3-89e093bc3b32"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttaqueLongueDistance"",
                    ""type"": ""Button"",
                    ""id"": ""31fa8877-4a3c-4eba-abf6-cdc7a1209aa7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ContreAttaque"",
                    ""type"": ""Button"",
                    ""id"": ""1f2bf8c2-63f0-45f8-b4d0-b59b12e67b4f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5c64c984-97d9-4acc-8217-722b0bb43e90"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attaque"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""672831ee-bd2d-4062-8471-4ec3e140d19c"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Esquive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bff2d8a8-f01d-460d-b9f5-53eebfe7f587"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttaqueLourde"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ca6acdb-6cfa-4163-a159-6d4ae4a6a9dc"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttaqueRapide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70727076-1c42-4fd3-bd85-00e0385d3764"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttaqueLongueDistance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4eb62176-8044-4512-97af-186b3dfddcb2"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ContreAttaque"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Flèche"",
                    ""id"": ""3e155a7f-e7c2-4680-a339-4d54a2f74f44"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""960b5566-ee0b-4e27-83d6-e4ef832aa8db"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6cbbebc8-d14c-4746-bef6-58e7c66db4f7"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7d170907-7e77-4af2-9b78-e265b84e0f0f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3affb2ad-18ca-4e31-b8f9-d4a22439806b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Combat
        m_Combat = asset.FindActionMap("Combat", throwIfNotFound: true);
        m_Combat_Move = m_Combat.FindAction("Move", throwIfNotFound: true);
        m_Combat_Attaque = m_Combat.FindAction("Attaque", throwIfNotFound: true);
        m_Combat_Esquive = m_Combat.FindAction("Esquive", throwIfNotFound: true);
        m_Combat_AttaqueLourde = m_Combat.FindAction("AttaqueLourde", throwIfNotFound: true);
        m_Combat_AttaqueRapide = m_Combat.FindAction("AttaqueRapide", throwIfNotFound: true);
        m_Combat_AttaqueLongueDistance = m_Combat.FindAction("AttaqueLongueDistance", throwIfNotFound: true);
        m_Combat_ContreAttaque = m_Combat.FindAction("ContreAttaque", throwIfNotFound: true);
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

    // Combat
    private readonly InputActionMap m_Combat;
    private ICombatActions m_CombatActionsCallbackInterface;
    private readonly InputAction m_Combat_Move;
    private readonly InputAction m_Combat_Attaque;
    private readonly InputAction m_Combat_Esquive;
    private readonly InputAction m_Combat_AttaqueLourde;
    private readonly InputAction m_Combat_AttaqueRapide;
    private readonly InputAction m_Combat_AttaqueLongueDistance;
    private readonly InputAction m_Combat_ContreAttaque;
    public struct CombatActions
    {
        private @PlayerActionControls m_Wrapper;
        public CombatActions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Combat_Move;
        public InputAction @Attaque => m_Wrapper.m_Combat_Attaque;
        public InputAction @Esquive => m_Wrapper.m_Combat_Esquive;
        public InputAction @AttaqueLourde => m_Wrapper.m_Combat_AttaqueLourde;
        public InputAction @AttaqueRapide => m_Wrapper.m_Combat_AttaqueRapide;
        public InputAction @AttaqueLongueDistance => m_Wrapper.m_Combat_AttaqueLongueDistance;
        public InputAction @ContreAttaque => m_Wrapper.m_Combat_ContreAttaque;
        public InputActionMap Get() { return m_Wrapper.m_Combat; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CombatActions set) { return set.Get(); }
        public void SetCallbacks(ICombatActions instance)
        {
            if (m_Wrapper.m_CombatActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnMove;
                @Attaque.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttaque;
                @Attaque.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttaque;
                @Attaque.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttaque;
                @Esquive.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnEsquive;
                @Esquive.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnEsquive;
                @Esquive.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnEsquive;
                @AttaqueLourde.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttaqueLourde;
                @AttaqueLourde.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttaqueLourde;
                @AttaqueLourde.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttaqueLourde;
                @AttaqueRapide.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttaqueRapide;
                @AttaqueRapide.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttaqueRapide;
                @AttaqueRapide.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttaqueRapide;
                @AttaqueLongueDistance.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttaqueLongueDistance;
                @AttaqueLongueDistance.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttaqueLongueDistance;
                @AttaqueLongueDistance.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttaqueLongueDistance;
                @ContreAttaque.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnContreAttaque;
                @ContreAttaque.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnContreAttaque;
                @ContreAttaque.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnContreAttaque;
            }
            m_Wrapper.m_CombatActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Attaque.started += instance.OnAttaque;
                @Attaque.performed += instance.OnAttaque;
                @Attaque.canceled += instance.OnAttaque;
                @Esquive.started += instance.OnEsquive;
                @Esquive.performed += instance.OnEsquive;
                @Esquive.canceled += instance.OnEsquive;
                @AttaqueLourde.started += instance.OnAttaqueLourde;
                @AttaqueLourde.performed += instance.OnAttaqueLourde;
                @AttaqueLourde.canceled += instance.OnAttaqueLourde;
                @AttaqueRapide.started += instance.OnAttaqueRapide;
                @AttaqueRapide.performed += instance.OnAttaqueRapide;
                @AttaqueRapide.canceled += instance.OnAttaqueRapide;
                @AttaqueLongueDistance.started += instance.OnAttaqueLongueDistance;
                @AttaqueLongueDistance.performed += instance.OnAttaqueLongueDistance;
                @AttaqueLongueDistance.canceled += instance.OnAttaqueLongueDistance;
                @ContreAttaque.started += instance.OnContreAttaque;
                @ContreAttaque.performed += instance.OnContreAttaque;
                @ContreAttaque.canceled += instance.OnContreAttaque;
            }
        }
    }
    public CombatActions @Combat => new CombatActions(this);
    public interface ICombatActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAttaque(InputAction.CallbackContext context);
        void OnEsquive(InputAction.CallbackContext context);
        void OnAttaqueLourde(InputAction.CallbackContext context);
        void OnAttaqueRapide(InputAction.CallbackContext context);
        void OnAttaqueLongueDistance(InputAction.CallbackContext context);
        void OnContreAttaque(InputAction.CallbackContext context);
    }
}
