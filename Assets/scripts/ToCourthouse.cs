using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ToCourthouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ProgressToCourthouse()
    {
        SceneManager.LoadScene("transition_1");
    }
}
