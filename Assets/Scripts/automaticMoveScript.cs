using UnityEngine;
using System.Collections;

public class automaticMoveScript : MonoBehaviour {
    Vector3 destination = new Vector3(0,1,15);
    float speed = 1;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        CharacterController charController = gameObject.GetComponent<CharacterController>();



        transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);

	}

    void OnGUI()
    {
        GUI.Label(new Rect(220.0f, 200.0f, 200.0f, 20.0f), transform.position.ToString("F3"));
    }
}
