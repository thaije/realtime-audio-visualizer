using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lasp;

public class Test : MonoBehaviour {

	public float[] _samples = new float[8];


	// Use this for initialization
	void Start () {
		
		Debug.Log(AudioInput.GetPeakLevel(FilterType.Bypass));

		AudioInput.RetrieveWaveform(FilterType.Bypass, _samples);

		Debug.Log(_samples[0]);

	}
	
	// Update is called once per frame
	void Update () {

		// Get the Root Mean Square of the frequencies
		float scale = AudioInput.CalculateRMS(FilterType.Bypass);

		// scale the circle accordingly
		scale = scale * 25;
		transform.localScale = new Vector3( scale, scale, scale);

		// read the frequencies in to the array
		AudioInput.RetrieveWaveform(FilterType.Bypass, _samples);


            
	}
}
