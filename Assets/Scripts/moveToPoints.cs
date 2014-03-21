using UnityEngine;
using System.Collections;

public class moveToPoints : MonoBehaviour {
    Vector3 destination = new Vector3(0, 1, 15);
    Vector3 sphereDestination = new Vector3();
    string sphereString = "Sphere1";

    public float speed = 10;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GameObject sphere = GameObject.Find(sphereString);
        destination = sphere.transform.position;
        gameObject.transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
    }

    void OnGUI()
    {
        GUI.Label(new Rect(280.0f, 180.0f, 200.0f, 20.0f), "destination position");
        GUI.Label(new Rect(280.0f, 200.0f, 200.0f, 20.0f), destination.ToString("F3"));
        GUI.Label(new Rect(280.0f, 240.0f, 200.0f, 20.0f), transform.position.ToString("F3"));
        GUI.Label(new Rect(280.0f, 220.0f, 200.0f, 20.0f), "current position");
    }
}
