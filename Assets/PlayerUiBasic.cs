/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UImGui;

public class PlayerUiBasic : MonoBehaviour
{
    [SerializeField] 
    private float _sliderFloatValue = 1;

    [SerializeField]
    private string _inputText;


    private void Awake()
	{
		UImGuiUtility.Layout += OnLayout;
		UImGuiUtility.OnInitialize += OnInitialize;
		UImGuiUtility.OnDeinitialize += OnDeinitialize;
	}

	private void OnLayout(UImGui.UImGui obj)
	{
		// Unity Update method. 
		// Your code belongs here! Like ImGui.Begin... etc.
        ImGui.Text($"Hello, world {123}");
        if (ImGui.Button("Save"))
        {
            Debug.Log("Save");
        }

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
		UImGuiUtility.Layout -= OnLayout;
		UImGuiUtility.OnInitialize -= OnInitialize;
		UImGuiUtility.OnDeinitialize -= OnDeinitialize;
	}
}
*/