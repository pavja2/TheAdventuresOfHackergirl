using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ParcelMenus : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	} 
	
	// Update is called once per frame
	void Update () {
	
	}

    public void loadPackageGame()
    {
        SceneManager.LoadScene("packagegame");
    }

    public void loadPackageGameover()
    {
        SceneManager.LoadScene("packagegameover");
        
    }

    public void loadTransition()
    {
        SceneManager.LoadScene("transition_2");
    }

    public void quitPackageGame()
    {
        SceneManager.LoadScene("loading_screen");
    }
}
