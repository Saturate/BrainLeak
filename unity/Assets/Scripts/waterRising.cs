using UnityEngine;
using System.Collections;

public class waterRising : MonoBehaviour {

  public float RiseSpeed;
	
	// Update is called once per frame
	void Update () {
    transform.position += Vector3.up * RiseSpeed;
  }
}
