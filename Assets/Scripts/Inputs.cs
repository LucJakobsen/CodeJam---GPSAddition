//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Inputs.inputactions
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

public partial class @Inputs : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputs"",
    ""maps"": [
        {
            ""name"": ""Sensors"",
            ""id"": ""7f96852b-0cea-4b35-bf9b-1faecb340c30"",
            ""actions"": [
                {
                    ""name"": ""Acceleration"",
                    ""type"": ""Value"",
                    ""id"": ""52bfb718-a631-4f65-b7ec-286777d80fd1"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Attitude"",
                    ""type"": ""Value"",
                    ""id"": ""8ee2b321-33d1-40af-9f09-039d46781cf2"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6fa6bd6d-7458-4365-be5c-a9390bfd4281"",
                    ""path"": ""<Accelerometer>/acceleration"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2533288a-3c7c-435c-83da-c018b0484d04"",
                    ""path"": ""<AttitudeSensor>/attitude"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attitude"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Sensors
        m_Sensors = asset.FindActionMap("Sensors", throwIfNotFound: true);
        m_Sensors_Acceleration = m_Sensors.FindAction("Acceleration", throwIfNotFound: true);
        m_Sensors_Attitude = m_Sensors.FindAction("Attitude", throwIfNotFound: true);
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

    // Sensors
    private readonly InputActionMap m_Sensors;
    private ISensorsActions m_SensorsActionsCallbackInterface;
    private readonly InputAction m_Sensors_Acceleration;
    private readonly InputAction m_Sensors_Attitude;
    public struct SensorsActions
    {
        private @Inputs m_Wrapper;
        public SensorsActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Acceleration => m_Wrapper.m_Sensors_Acceleration;
        public InputAction @Attitude => m_Wrapper.m_Sensors_Attitude;
        public InputActionMap Get() { return m_Wrapper.m_Sensors; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SensorsActions set) { return set.Get(); }
        public void SetCallbacks(ISensorsActions instance)
        {
            if (m_Wrapper.m_SensorsActionsCallbackInterface != null)
            {
                @Acceleration.started -= m_Wrapper.m_SensorsActionsCallbackInterface.OnAcceleration;
                @Acceleration.performed -= m_Wrapper.m_SensorsActionsCallbackInterface.OnAcceleration;
                @Acceleration.canceled -= m_Wrapper.m_SensorsActionsCallbackInterface.OnAcceleration;
                @Attitude.started -= m_Wrapper.m_SensorsActionsCallbackInterface.OnAttitude;
                @Attitude.performed -= m_Wrapper.m_SensorsActionsCallbackInterface.OnAttitude;
                @Attitude.canceled -= m_Wrapper.m_SensorsActionsCallbackInterface.OnAttitude;
            }
            m_Wrapper.m_SensorsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Acceleration.started += instance.OnAcceleration;
                @Acceleration.performed += instance.OnAcceleration;
                @Acceleration.canceled += instance.OnAcceleration;
                @Attitude.started += instance.OnAttitude;
                @Attitude.performed += instance.OnAttitude;
                @Attitude.canceled += instance.OnAttitude;
            }
        }
    }
    public SensorsActions @Sensors => new SensorsActions(this);
    public interface ISensorsActions
    {
        void OnAcceleration(InputAction.CallbackContext context);
        void OnAttitude(InputAction.CallbackContext context);
    }
}
