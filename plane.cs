using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;


public class player : MonoBehaviour {
    
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
 

    Vector3 tempos;
    float m_vertical;
    float m_horizontal;
    float speed = 0.1f;
    float tempo = 1.0f;
    float rotspeed = 5.0f;

    private AudioSource source;


	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
        AudioSource audio = GetComponent<AudioSource>();
        
        //audio.Play();
        //audio.Play(44100);
    }
    // Update is called once per frame
    void Update()
    {

        //yourobject.transform.Translate(MovementVector, Space.Self);

        // Lines C - E G B D F 


        if (MidiMaster.GetKeyDown(C3))
        {
            transform.position = new Vector3(0.0f, -0.5f, 0.0f);
            OC3.SetActive(true);
            source.PlayOneShot(MC3, 1.0f);
        }
        if (MidiMaster.GetKeyUp(C3))
        {
            OC3.SetActive(false);
        }



        if (MidiMaster.GetKeyDown(E3))
        { 
            transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            source.PlayOneShot(ME3, 1.0f);
            OE3.SetActive(true);
           
        }
        if (MidiMaster.GetKeyUp(E3))
        {
           OE3.SetActive(false);
        }



        if (MidiMaster.GetKeyDown(G3)) { 
            transform.position = new Vector3(0.0f, 0.5f, 0.0f);
            OG3.SetActive(true);
            source.PlayOneShot(MG3, 1.0f);
        }
        if (MidiMaster.GetKeyUp(G3))
        {
           OG3.SetActive(false);
        }



        if (MidiMaster.GetKeyDown(B3)) { 
            transform.position = new Vector3(0.0f, 1.0f, 0.0f);
            OB3.SetActive(true);
            source.PlayOneShot(MB3, 1.0f);
        }
        if (MidiMaster.GetKeyUp(B3))
        {
            OB3.SetActive(false);
        }

    

        if (MidiMaster.GetKeyDown(D4)) { 
            transform.position = new Vector3(0.0f, 1.5f, 0.0f);
            OD4.SetActive(true);
            source.PlayOneShot(MD4, 1.0f);
        }
        if (MidiMaster.GetKeyUp(D4))
        {
            OD4.SetActive(false);
        }





        if (MidiMaster.GetKeyDown(F4)) { 
            transform.position = new Vector3(0.0f, 2.0f, 0.0f);
            OF4.SetActive(true);
            source.PlayOneShot(MF4, 1.0f);
        }

        if (MidiMaster.GetKeyUp(F4))
        {
            OF4.SetActive(false);
        }


        //################### spaces F A C E #########################################

        if (MidiMaster.GetKeyDown(D3))
        {
            transform.position = new Vector3(0.0f, -0.25f, 0.0f);
            OD3.SetActive(true);
            source.PlayOneShot(MD3, 1.0f);
        }

        if (MidiMaster.GetKeyUp(D3))
        {
            OD3.SetActive(false);
        }


        if (MidiMaster.GetKeyDown(F3)) { 
            transform.position = new Vector3(0.0f, 0.25f, 0.0f);
            OF3.SetActive(true);
            source.PlayOneShot(MF3, 1.0f);
        }
        if (MidiMaster.GetKeyUp(F3))
        {
            OF3.SetActive(false);
        }





        if (MidiMaster.GetKeyDown(A3)){ 
            transform.position = new Vector3(0.0f, 0.75f, 0.0f);
            OA3.SetActive(true);
            source.PlayOneShot(MA3, 1.0f);
        }
        if (MidiMaster.GetKeyUp(A3))
        {
            OA3.SetActive(false);
        }



        if (MidiMaster.GetKeyDown(C4)) { 
            transform.position = new Vector3(0.0f, 1.25f, 0.0f);
            OC4.SetActive(true);
            source.PlayOneShot(MC4, 1.0f);
        }
        if (MidiMaster.GetKeyUp(C4))
        {
            OC4.SetActive(false);
        }




        if (MidiMaster.GetKeyDown(E4))
        { 
            transform.position = new Vector3(0.0f, 1.75f, 0.0f);
            OE4.SetActive(true);
            source.PlayOneShot(ME4, 1.0f);
        }

          if (MidiMaster.GetKeyUp(E4))
        {
            OE4.SetActive(false);
        }


        //transform.Translate(Vector3.up  * speed);
        //print(transform.position.x);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.down * speed);

    }
}
