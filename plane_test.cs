using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack

//Hany is trying to use functions

public class plane : MonoBehaviour { //the class plane inherites class monobehaviour
    
    //Note name and equivalent midi number dictionary
    Dictionary<string, int> dict = new Dictionary<string, int>();
    dict.Add("C3", 60);
    dict.Add("D3", 62);
    dict.Add("E3", 64);
    dict.Add("F3", 65);
    dict.Add("G3", 67);
    dict.Add("A3", 69);
    dict.Add("B3", 71);
    dict.Add("C4", 72);
    dict.Add("D4", 74);
    dict.Add("E4", 76);
    dict.Add("F4", 77);
    
    //Lines and spaces coordinates
    float E3_x;
    float E3_y;
    float E3_z;
    
    
    // Use this for initialization
    void Start () {
      source = GetComponent<AudioSource>();
      }
    
    
    // Plane Repositioning
    void update_plane_position () {
            transform.position = new Vector3(-1.47f, 0.582f, 1.14f);
    }
    
    //Update staff position
    void Update_staff_position (float E3_x, float E3_y, float E3_z) {
    	List<float> E3_xyz = new List<float> ();
		E3_xyz.Add (E3_x);
		E3_xyz.Add (E3_y);
		E3_xyz.Add (E3_z);

	List<float> F3_xyz = new List<float> ();
		F3_xyz.Add (E3_xyz [0] + 1.0f);
		F3_xyz.Add (E3_y);
		F3_xyz.Add (E3_z);

	List<float> G3_xyz = new List<float> ();
		G3_xyz.Add (E3_xyz [0] + 2.0f);
		G3_xyz.Add (E3_xyz [1]);
		G3_xyz.Add (E3_xyz [2]);
    
    

    
    
    

  


