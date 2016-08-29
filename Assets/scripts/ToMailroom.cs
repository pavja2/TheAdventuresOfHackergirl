using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ToMailroom : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ProgressToMailroom()
    {
        SceneManager.LoadScene("transition_2");
    }
}
