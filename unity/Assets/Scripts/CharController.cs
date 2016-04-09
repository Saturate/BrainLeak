using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {

    CharacterController cc;
    public float speed;    
    // Use this for initialization
    void Start () {

        cc = GetComponent<CharacterController>();
	}
	
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        transform.Rotate(new Vector3(0.0f, moveHorizontal * speed*10));
        var test = transform.TransformDirection(0.0f, 0.0f, moveVertical * speed);
        Vector3 movement = new Vector3(0.0f, 0.0f, moveVertical* speed);
        
        cc.Move(test);
        

       
    }
}
