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
    private int _sliderIntValue = 1;

	[SerializeField]
    private float _sliderFloatValue = 1f;

    [SerializeField]
    private string _inputText;

	public float DEMO_SelectArticulation = 0.5f;
	public float DEMO_SelectSonic = 0.5f;
	public float DEMO_SelectProximity = 0.5f;
	public float DEMO_SelectMixing = 0.5f;

	public bool isPlaying = true;
	public GameObject Cover;
	public float MaxCoverRotation = 10.0f;

	// Demo Stuff
	public GameObject DemoGuitarAStaccatoAcoustic;
	public float DemoGuitarAStaccatoAcousticOffset = 0.0f;
	public GameObject DemoGuitarALegatoAcoustic;
	public float DemoGuitarALegatoAcousticOffset = 0.0f;
	public GameObject DemoGuitarAStaccatoElectric;
	public float DemoGuitarAStaccatoElectricOffset = 0.0f;
	public GameObject DemoGuitarALegatoElectric;
	public float DemoGuitarALegatoElectricOffset = 0.0f;

	public GameObject DemoGuitarBStaccatoAcoustic;
	public float DemoGuitarBStaccatoAcousticOffset = 0.0f;
	public GameObject DemoGuitarBLegatoAcoustic;
	public float DemoGuitarBLegatoAcousticOffset = 0.0f;
	public GameObject DemoGuitarBStaccatoElectric;
	public float DemoGuitarBStaccatoElectricOffset = 0.0f;
	public GameObject DemoGuitarBLegatoElectric;
	public float DemoGuitarBLegatoElectricOffset = 0.0f;
	
	public GameObject DemoPiano;
	public float DemoPianoOffset = 0.0f;


	public float GuitarVolume = 1.0f;
	public float GuitarAVolume = 1.0f;
	public float GuitarALegatoVolume = 1.0f;
	public float GuitarAStaccatoVolume = 1.0f;
	public float GuitarBVolume = 1.0f;
	public float GuitarBLegatoVolume = 1.0f;
	public float GuitarBStaccatoVolume = 1.0f;
	public float PianoVolume = 1.0f;

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
        //ImGui.Text($"I am clearly the greatest programmer that ever lived.");
		/*ImGui.Text($"Song Properties");
        if (ImGui.Button("this button does nothing"))
        {
            Debug.Log("sike it does something");
        }
        ImGui.RadioButton("A -> 1", ref testInt, 1);
        ImGui.RadioButton("A -> 2", ref testInt, 2);
        ImGui.RadioButton("A -> 3", ref testInt, 3);
        
        ImGui.Checkbox("Use Location", ref testBool);
        ImGui.InputText("Location", ref _inputText, 100);
        ImGui.SliderFloat("Intensity", ref _sliderFloatValue, 0.0f, 1.0f); */
		/*
		ImGui.Text("STEM ADDITION MODE A: Linear Addition Blend");
		ImGui.SliderInt("MODE A INPUT: Blend", ref _sliderIntValue, 0, 5);
		ImGui.Spacing();
		ImGui.Text("TONE SELECTION MODE A: Linear 'Select From' Blend");
		ImGui.SliderFloat("ACOUSTIC <--> ELECTRIC", ref _sliderFloatValue, 0.0f, 1.0f);
		*/
		ImGui.Text("Linear Blend Selection: Articulation Spectrum");
		ImGui.Text("Player Movement Speed");
		ImGui.SliderFloat("LBS_1", ref DEMO_SelectArticulation, 0.0f, 1.0f);
		ImGui.Text("Primary Guitar: Staccato <--> Legato");

		ImGui.Spacing(); ImGui.Spacing(); ImGui.Spacing();
		ImGui.Spacing(); ImGui.Spacing(); ImGui.Spacing();

		ImGui.Text("Linear Blend Selection: Sonic Spectrum");
		ImGui.Text("Player Location in Level");
		ImGui.SliderFloat("LBS_2", ref DEMO_SelectSonic, 0.0f, 1.0f);
		ImGui.Text("Primary Guitar: Acoustic <--> Electric");

		ImGui.Spacing(); ImGui.Spacing(); ImGui.Spacing();
		ImGui.Spacing(); ImGui.Spacing(); ImGui.Spacing();

		ImGui.Text("Linear Blend: Proximity");
		ImGui.Text("Proximity to Specific Location");
		ImGui.SliderFloat("LBS_3", ref DEMO_SelectProximity, 0.0f, 1.0f);
		ImGui.Text("Pianos: Volume");

		ImGui.Spacing(); ImGui.Spacing(); ImGui.Spacing();
		ImGui.Spacing(); ImGui.Spacing(); ImGui.Spacing();

		ImGui.Text("Linear Blend Selection: Mixing Spectrum");
		ImGui.Text("Interfaces Open/Close");
		ImGui.SliderFloat("LBS_4", ref DEMO_SelectMixing, 0.0f, 1.0f);
		ImGui.Text("Melody/Chorus");
		
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
	private void Update()
	{
		/*
		 PianoVolume = DEMO_SelectProximity;
		 float PianoVolumeOut = PianoVolume * DemoPianoOffset;
		 GuitarVolume = 1 - PianoVolume;
			 GuitarBVolume = GuitarVolume * (1 - DEMO_SelectSonic);
				 GuitarBLegatoVolume = GuitarBVolume * (1 - DEMO_SelectArticulation);
					float DemoGuitarBLegatoAcousticVolume = GuitarBLegatoVolume * (1 - DEMO_SelectSonic) * DemoGuitarBLegatoAcousticOffset;
					float DemoGuitarBLegatoElectricVolume = GuitarBLegatoVolume * (DEMO_SelectSonic) * DemoGuitarBLegatoElectricOffset;
				 GuitarBStaccatoVolume = GuitarBVolume * (DEMO_SelectArticulation);
					float DemoGuitarBStaccatoAcousticVolume = GuitarBStaccatoVolume * (1 - DEMO_SelectSonic) * DemoGuitarBStaccatoAcousticOffset;
					float DemoGuitarBStaccatoElectricVolume = GuitarBStaccatoVolume * (DEMO_SelectSonic) * DemoGuitarBStaccatoElectricOffset;
			 GuitarAVolume = GuitarVolume * (DEMO_SelectSonic);
				 GuitarALegatoVolume = GuitarAVolume * (1 - DEMO_SelectArticulation);
					float DemoGuitarALegatoAcousticVolume = GuitarALegatoVolume * (1 - DEMO_SelectSonic) * DemoGuitarALegatoAcousticOffset;
					float DemoGuitarALegatoElectricVolume = GuitarALegatoVolume * (DEMO_SelectSonic) * DemoGuitarALegatoElectricOffset;
				 GuitarAStaccatoVolume = GuitarAVolume * (DEMO_SelectArticulation);
					float DemoGuitarAStaccatoAcousticVolume = GuitarAStaccatoVolume * (1 - DEMO_SelectSonic) * DemoGuitarAStaccatoAcousticOffset;
					float DemoGuitarAStaccatoElectricVolume = GuitarAStaccatoVolume * (DEMO_SelectSonic) * DemoGuitarAStaccatoElectricOffset; */
		
		float baseVolume = 1f;
		PianoVolume = DEMO_SelectProximity;
		float PianoVolumeOut = PianoVolume * DemoPianoOffset;
		GuitarVolume = 1 - PianoVolume;
			GuitarAVolume = (GuitarVolume * (DEMO_SelectMixing));
				GuitarALegatoVolume = GuitarAVolume * (DEMO_SelectArticulation);
					float DemoGuitarALegatoAcousticVolume = GuitarALegatoVolume * (1 - DEMO_SelectSonic) * DemoGuitarALegatoAcousticOffset;
					float DemoGuitarALegatoElectricVolume = GuitarALegatoVolume * (DEMO_SelectSonic) * DemoGuitarALegatoElectricOffset;
				GuitarAStaccatoVolume = GuitarAVolume * (1 - DEMO_SelectArticulation);
					float DemoGuitarAStaccatoAcousticVolume = GuitarAStaccatoVolume * (1 - DEMO_SelectSonic) * DemoGuitarAStaccatoAcousticOffset;
					float DemoGuitarAStaccatoElectricVolume = GuitarAStaccatoVolume * (DEMO_SelectSonic) * DemoGuitarAStaccatoElectricOffset;
			GuitarBVolume = (GuitarVolume * (1 - DEMO_SelectMixing));
				GuitarBLegatoVolume = GuitarBVolume * (DEMO_SelectArticulation);
					float DemoGuitarBLegatoAcousticVolume = GuitarBLegatoVolume * (1 - DEMO_SelectSonic) * DemoGuitarBLegatoAcousticOffset;
					float DemoGuitarBLegatoElectricVolume = GuitarBLegatoVolume * (DEMO_SelectSonic) * DemoGuitarBLegatoElectricOffset;
				GuitarBStaccatoVolume = GuitarBVolume * (1 - DEMO_SelectArticulation);
					float DemoGuitarBStaccatoAcousticVolume = GuitarBStaccatoVolume * (1 - DEMO_SelectSonic) * DemoGuitarBStaccatoAcousticOffset;
					float DemoGuitarBStaccatoElectricVolume = GuitarBStaccatoVolume * (DEMO_SelectSonic) * DemoGuitarBStaccatoElectricOffset;

		DemoGuitarALegatoAcoustic.GetComponent<AudioSource>().volume = DemoGuitarALegatoAcousticVolume;
		DemoGuitarALegatoElectric.GetComponent<AudioSource>().volume = DemoGuitarALegatoElectricVolume;
		DemoGuitarAStaccatoAcoustic.GetComponent<AudioSource>().volume = DemoGuitarAStaccatoAcousticVolume;
		DemoGuitarAStaccatoElectric.GetComponent<AudioSource>().volume = DemoGuitarAStaccatoElectricVolume;
		DemoGuitarBLegatoAcoustic.GetComponent<AudioSource>().volume = DemoGuitarBLegatoAcousticVolume;
		DemoGuitarBLegatoElectric.GetComponent<AudioSource>().volume = DemoGuitarBLegatoElectricVolume;
		DemoGuitarBStaccatoAcoustic.GetComponent<AudioSource>().volume = DemoGuitarBStaccatoAcousticVolume;
		DemoGuitarBStaccatoElectric.GetComponent<AudioSource>().volume = DemoGuitarBStaccatoElectricVolume;
		DemoPiano.GetComponent<AudioSource>().volume = PianoVolumeOut;

		Cover.transform.rotation = Quaternion.Euler(MaxCoverRotation * (DEMO_SelectArticulation - 0.5f)*4, MaxCoverRotation * (DEMO_SelectSonic- 0.5f)*4, MaxCoverRotation * (DEMO_SelectMixing- 0.5f)*1.2f);
		Cover.transform.localScale = new Vector3(1.0f + (DEMO_SelectProximity - 0.5f)*0.2f, 1.0f + (DEMO_SelectProximity - 0.5f)*0.2f, 1.0f + (DEMO_SelectProximity - 0.5f)*0.2f);
	}

	public void Demo_pauseplay()
	{
		if(isPlaying)
		{
			isPlaying = false;
			DemoGuitarALegatoAcoustic.GetComponent<AudioSource>().Pause();
			DemoGuitarALegatoElectric.GetComponent<AudioSource>().Pause();
			DemoGuitarAStaccatoAcoustic.GetComponent<AudioSource>().Pause();
			DemoGuitarAStaccatoElectric.GetComponent<AudioSource>().Pause();
			DemoGuitarBLegatoAcoustic.GetComponent<AudioSource>().Pause();
			DemoGuitarBLegatoElectric.GetComponent<AudioSource>().Pause();
			DemoGuitarBStaccatoAcoustic.GetComponent<AudioSource>().Pause();
			DemoGuitarBStaccatoElectric.GetComponent<AudioSource>().Pause();
			DemoPiano.GetComponent<AudioSource>().Pause();
		} else 
		{
			isPlaying = true;
			DemoGuitarALegatoAcoustic.GetComponent<AudioSource>().Play();
			DemoGuitarALegatoElectric.GetComponent<AudioSource>().Play();
			DemoGuitarAStaccatoAcoustic.GetComponent<AudioSource>().Play();
			DemoGuitarAStaccatoElectric.GetComponent<AudioSource>().Play();
			DemoGuitarBLegatoAcoustic.GetComponent<AudioSource>().Play();
			DemoGuitarBLegatoElectric.GetComponent<AudioSource>().Play();
			DemoGuitarBStaccatoAcoustic.GetComponent<AudioSource>().Play();
			DemoGuitarBStaccatoElectric.GetComponent<AudioSource>().Play();
			DemoPiano.GetComponent<AudioSource>().Play();
		}
	}
	public void Demo_restart()
	{
		DemoGuitarALegatoAcoustic.GetComponent<AudioSource>().Stop();
		DemoGuitarALegatoElectric.GetComponent<AudioSource>().Stop();
		DemoGuitarAStaccatoAcoustic.GetComponent<AudioSource>().Stop();
		DemoGuitarAStaccatoElectric.GetComponent<AudioSource>().Stop();
		DemoGuitarBLegatoAcoustic.GetComponent<AudioSource>().Stop();
		DemoGuitarBLegatoElectric.GetComponent<AudioSource>().Stop();
		DemoGuitarBStaccatoAcoustic.GetComponent<AudioSource>().Stop();
		DemoGuitarBStaccatoElectric.GetComponent<AudioSource>().Stop();
		DemoPiano.GetComponent<AudioSource>().Stop();

		DemoGuitarALegatoAcoustic.GetComponent<AudioSource>().Play();
		DemoGuitarALegatoElectric.GetComponent<AudioSource>().Play();
		DemoGuitarAStaccatoAcoustic.GetComponent<AudioSource>().Play();
		DemoGuitarAStaccatoElectric.GetComponent<AudioSource>().Play();
		DemoGuitarBLegatoAcoustic.GetComponent<AudioSource>().Play();
		DemoGuitarBLegatoElectric.GetComponent<AudioSource>().Play();
		DemoGuitarBStaccatoAcoustic.GetComponent<AudioSource>().Play();
		DemoGuitarBStaccatoElectric.GetComponent<AudioSource>().Play();
		DemoPiano.GetComponent<AudioSource>().Play();
	}
}