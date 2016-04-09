using UnityEngine;
using System.Collections;

public class footsteps : MonoBehaviour {

  private CharacterController cc;
  private AudioSource audio;
	// Use this for initialization
	void Start () {
    cc = GetComponent<CharacterController>();
    audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	  if(cc.velocity.magnitude > 0 && !audio.isPlaying) {
      audio.Play();
    }
	}
}
