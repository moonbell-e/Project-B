//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input System/Inputs.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Inputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputs"",
    ""maps"": [
        {
            ""name"": ""MouseScroll"",
            ""id"": ""cce17754-df8a-44dd-a8db-fffb9b68ad79"",
            ""actions"": [
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""dc76fbd0-b212-4c74-9b6e-c692ca14512b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""386e64d7-013a-4669-9a4b-17259d77ec57"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9ddfa2ca-00dd-4dff-ac18-9d4badd84918"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3dcb7cd3-1b2c-4253-9459-0866211f7c17"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MouseScroll
        m_MouseScroll = asset.FindActionMap("MouseScroll", throwIfNotFound: true);
        m_MouseScroll_Zoom = m_MouseScroll.FindAction("Zoom", throwIfNotFound: true);
        m_MouseScroll_Newaction = m_MouseScroll.FindAction("New action", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // MouseScroll
    private readonly InputActionMap m_MouseScroll;
    private List<IMouseScrollActions> m_MouseScrollActionsCallbackInterfaces = new List<IMouseScrollActions>();
    private readonly InputAction m_MouseScroll_Zoom;
    private readonly InputAction m_MouseScroll_Newaction;
    public struct MouseScrollActions
    {
        private @Inputs m_Wrapper;
        public MouseScrollActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Zoom => m_Wrapper.m_MouseScroll_Zoom;
        public InputAction @Newaction => m_Wrapper.m_MouseScroll_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_MouseScroll; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseScrollActions set) { return set.Get(); }
        public void AddCallbacks(IMouseScrollActions instance)
        {
            if (instance == null || m_Wrapper.m_MouseScrollActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MouseScrollActionsCallbackInterfaces.Add(instance);
            @Zoom.started += instance.OnZoom;
            @Zoom.performed += instance.OnZoom;
            @Zoom.canceled += instance.OnZoom;
            @Newaction.started += instance.OnNewaction;
            @Newaction.performed += instance.OnNewaction;
            @Newaction.canceled += instance.OnNewaction;
        }

        private void UnregisterCallbacks(IMouseScrollActions instance)
        {
            @Zoom.started -= instance.OnZoom;
            @Zoom.performed -= instance.OnZoom;
            @Zoom.canceled -= instance.OnZoom;
            @Newaction.started -= instance.OnNewaction;
            @Newaction.performed -= instance.OnNewaction;
            @Newaction.canceled -= instance.OnNewaction;
        }

        public void RemoveCallbacks(IMouseScrollActions instance)
        {
            if (m_Wrapper.m_MouseScrollActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMouseScrollActions instance)
        {
            foreach (var item in m_Wrapper.m_MouseScrollActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MouseScrollActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MouseScrollActions @MouseScroll => new MouseScrollActions(this);
    public interface IMouseScrollActions
    {
        void OnZoom(InputAction.CallbackContext context);
        void OnNewaction(InputAction.CallbackContext context);
    }
}