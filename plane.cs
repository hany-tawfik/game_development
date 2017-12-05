using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;


public class plane : MonoBehaviour {

    public AudioClip MC3, MD3, ME3, MF3, MG3, MA3, MB3, MC4, MD4, ME4, MF4, MG4, MA4, MB4;
    public GameObject OC3, OD3, OE3, OF3, OG3, OA3, OB3, OC4, OD4, OE4, OF4, OG4, OA4, OB4, OC5;
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
    int key_number;
    



    float m_vertical;
    float m_horizontal;
    float speed = 0.1f;

    private AudioSource source;


	// Use this for initialization
	void Start () {
            source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //yourobject.transform.Translate(MovementVector, Space.Self);
	    
	/*if (MidiMaster.GetKeyDown(key_number >= 1 && key_number <= 100))
        {
            transform.position = new Vector3(-1.47f, 0.582f, 1.14f);
            OD3.SetActive(true);
            source.PlayOneShot(key_number, 1.0f);*/

        // Lines E G B D F A
        if (MidiMaster.GetKeyDown(D3))
        {
            transform.position = new Vector3(-1.47f, 0.582f, 1.14f);
            OD3.SetActive(true);
            source.PlayOneShot(MD3, 1.0f);
        }

        if (MidiMaster.GetKeyDown(E3))
        { 
            transform.position = new Vector3(-1.47f, -0.6f, 1.14f);
            source.PlayOneShot(ME3, 1.0f);
            OE3.SetActive(true);
           
        }
        if (MidiMaster.GetKeyDown(G3)) { 
            transform.position = new Vector3(-1.47f, -0.22f, 1.14f);
            OG3.SetActive(true);
            source.PlayOneShot(MG3, 1.0f);
        }
        if (MidiMaster.GetKeyDown(B3)) { 
            transform.position = new Vector3(-1.47f, 0.19f, 1.14f);
            OB3.SetActive(true);
            source.PlayOneShot(MB3, 1.0f);
        }

        if (MidiMaster.GetKeyDown(D4)) { 
            transform.position = new Vector3(-1.47f, 0.582f, 1.14f);
            OD4.SetActive(true);
            source.PlayOneShot(MD4, 1.0f);
        }

        if (MidiMaster.GetKeyDown(F4)) { 
            transform.position = new Vector3(-1.47f, 0.984f, 1.14f);
            OF4.SetActive(true);
            source.PlayOneShot(MF4, 1.0f);
        }



        //spaces F A C E



        if (MidiMaster.GetKeyDown(C3))
        {
            transform.position = new Vector3(-1.47f, -1.0f, 1.14f);
            OC3.SetActive(true);
            source.PlayOneShot(MC3, 1.0f);
        }

        if (MidiMaster.GetKeyDown(F3)) { 
            transform.position = new Vector3(-1.47f, -0.4f, 1.14f);
            OF3.SetActive(true);
            source.PlayOneShot(MF3, 1.0f);
        }

        if (MidiMaster.GetKeyDown(A3)){ 
            transform.position = new Vector3(-1.47f, -0.018f, 1.14f);
            OA3.SetActive(true);
            source.PlayOneShot(MA3, 1.0f);
        }
        if (MidiMaster.GetKeyDown(C4)) { 
            transform.position = new Vector3(-1.47f, 0.3f, 1.14f);
            OC4.SetActive(true);
            source.PlayOneShot(MC4, 1.0f);
        }

        if (MidiMaster.GetKeyDown(E4)) { 
            transform.position = new Vector3(-1.47f, 0.765f, 1.14f);
            OE4.SetActive(true);
            source.PlayOneShot(ME4, 1.0f);
        }


        //transform.Translate(Vector3.up  * speed);
        //print(transform.position.x);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.down * speed);

    }
}
