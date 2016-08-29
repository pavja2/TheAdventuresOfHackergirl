using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ToFinale : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ProgressToMailroom()
    {
        SceneManager.LoadScene("final_scene");
    }
}
