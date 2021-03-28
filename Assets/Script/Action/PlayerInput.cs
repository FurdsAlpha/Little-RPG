// GENERATED AUTOMATICALLY FROM 'Assets/Script/Action/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace PlayerInput
{
    public class @PlayerInput : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Land"",
            ""id"": ""9f28a307-376c-445c-8ed8-0e0fff80d8fe"",
            ""actions"": [
                {
                    ""name"": ""Inventaire"",
                    ""type"": ""Button"",
                    ""id"": ""a7466572-6cf2-46b5-97ed-8227faf39c27"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""20617c9c-0212-4db4-bea3-237dd2d8f738"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventaire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Land
            m_Land = asset.FindActionMap("Land", throwIfNotFound: true);
            m_Land_Inventaire = m_Land.FindAction("Inventaire", throwIfNotFound: true);
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

        // Land
        private readonly InputActionMap m_Land;
        private ILandActions m_LandActionsCallbackInterface;
        private readonly InputAction m_Land_Inventaire;
        public struct LandActions
        {
            private @PlayerInput m_Wrapper;
            public LandActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Inventaire => m_Wrapper.m_Land_Inventaire;
            public InputActionMap Get() { return m_Wrapper.m_Land; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(LandActions set) { return set.Get(); }
            public void SetCallbacks(ILandActions instance)
            {
                if (m_Wrapper.m_LandActionsCallbackInterface != null)
                {
                    @Inventaire.started -= m_Wrapper.m_LandActionsCallbackInterface.OnInventaire;
                    @Inventaire.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnInventaire;
                    @Inventaire.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnInventaire;
                }
                m_Wrapper.m_LandActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Inventaire.started += instance.OnInventaire;
                    @Inventaire.performed += instance.OnInventaire;
                    @Inventaire.canceled += instance.OnInventaire;
                }
            }
        }
        public LandActions @Land => new LandActions(this);
        public interface ILandActions
        {
            void OnInventaire(InputAction.CallbackContext context);
        }
    }
}
