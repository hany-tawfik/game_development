using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;



public class midi : MonoBehaviour {


	int C3 = 60;
	int D3 = 62;
	int E3 = 64;
	int F3 = 65;
	int G3 = 67;
	int A3 = 69;
	int B3 = 71;
	int C4 = 72;
	int D4 = 74;
	int E4 = 76;
	int F4 = 77;
	//bool HC;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (MidiMaster.GetKeyDown (C3)) {
			Debug.Log ("This is an C3 note.");
			Debug.Log (C3);
		}
		else if (MidiMaster.GetKeyDown (D3)) {
			Debug.Log ("This is an D3 note.");
			Debug.Log (D3);
		}
		else if (MidiMaster.GetKeyDown (E3)) {
			Debug.Log ("This is an E3 note.");
			Debug.Log (E3);
		}
		else if (MidiMaster.GetKeyDown (F3)) {
			Debug.Log ("This is an F3 note.");
			Debug.Log (F3);
		}
		else if (MidiMaster.GetKeyDown (G3)) {
			Debug.Log ("This is an G3 note.");
			Debug.Log (G3);
		}
		else if (MidiMaster.GetKeyDown (A3)) {
			Debug.Log ("This is an A3 note.");
			Debug.Log (A3);
		}
		else if (MidiMaster.GetKeyDown (B3)) {
			Debug.Log ("This is an B3 note.");
			Debug.Log (B3);
		}
		else if (MidiMaster.GetKeyDown (C4)) {
			Debug.Log ("This is an C4 note.");
			Debug.Log (C4);
		}
		else if (MidiMaster.GetKeyDown (D4)) {
			Debug.Log ("This is an D4 note.");
			Debug.Log (D4);
		}
		else if (MidiMaster.GetKeyDown (E4)) {
			Debug.Log ("This is an E3 note.");
			Debug.Log (E4);
		}
		else if (MidiMaster.GetKeyDown (F4)) {
			Debug.Log ("This is an F4 note.");
			Debug.Log (F4);
		}

		//HC = MidiMaster.GetKeyDown(noteNumber);
		//Debug.Log(HC);
	}
}
