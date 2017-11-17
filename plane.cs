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
    
    E3
    
    // Use this for initialization
    void Start () {
              source = GetComponent<AudioSource>();
      }
    
    
    // Repositioning
	  void new_position () {
            transform.position = new Vector3(-1.47f, 0.582f, 1.14f);
    }

    
    
    

  


