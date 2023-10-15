using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ImGui = ImGuiNET.ImGui;
using UImGui;
public class InstanceSample : MonoBehaviour
{
	[SerializeField]
	private UImGui.UImGui _uimGuiInstance;

    [SerializeField]
    private float _sliderFloatValue = 1;

    [SerializeField]
    private string _inputText;

    public bool testBool = false;
    public int testInt = 0;

	private void Awake()
	{
		if (_uimGuiInstance == null)
		{
			Debug.LogError("Must assign a UImGuiInstance or use UImGuiUtility with Do Global Events on UImGui component.");
		}

		_uimGuiInstance.Layout += OnLayout;
		_uimGuiInstance.OnInitialize += OnInitialize;
		_uimGuiInstance.OnDeinitialize += OnDeinitialize;
	}

	private void OnLayout(UImGui.UImGui obj)
	{
		// Unity Update method. 
		// Your code belongs here! Like ImGui.Begin... etc.
        ImGui.Text($"I am clearly the greatest programmer that ever lived.");
        if (ImGui.Button("this button does nothing"))
        {
            Debug.Log("sike it does something");
        }
        ImGui.RadioButton("A -> 1", ref testInt, 1);
        ImGui.RadioButton("A -> 2", ref testInt, 2);
        ImGui.RadioButton("A -> 3", ref testInt, 3);
        
        ImGui.Checkbox("bool", ref testBool);
        ImGui.InputText("string", ref _inputText, 100);
        ImGui.SliderFloat("float", ref _sliderFloatValue, 0.0f, 1.0f);
	}

	private void OnInitialize(UImGui.UImGui obj)
	{
		// runs after UImGui.OnEnable();
	}

	private void OnDeinitialize(UImGui.UImGui obj)
	{
		// runs after UImGui.OnDisable();
	}

	private void OnDisable()
	{
		_uimGuiInstance.Layout -= OnLayout;
		_uimGuiInstance.OnInitialize -= OnInitialize;
		_uimGuiInstance.OnDeinitialize -= OnDeinitialize;
	}
}