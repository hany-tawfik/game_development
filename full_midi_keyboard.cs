if (i>0 & i<127){

  
  
  if (MidiMaster.GetKeyDown(D3))
        {
            transform.position = new Vector3(-1.47f, 0.582f, 1.14f);// new position
            OD3.SetActive(true); //green high lighting
            source.PlayOneShot(MD3, 1.0f); //play sound
