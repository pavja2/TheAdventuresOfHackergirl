using UnityEngine;
using System.Collections;


public class StationSpeaker : MonoBehaviour {
    public GameObject speaker;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnEnable()
    {
        print("here");
        print(speaker.name);
        print(GameObject.Find("hackergirl").GetComponent<Renderer>());
        if (speaker.name == "hackergirl")
        {
            GameObject.Find("policechief").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("hackergirl").GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (speaker.name == "policechief")
        {
            GameObject.Find("hackergirl").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("policechief").GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
