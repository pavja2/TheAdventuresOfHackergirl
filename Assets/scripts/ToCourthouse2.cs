using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ToCourthouse2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ProgressToCourthouse()
    {
        SceneManager.LoadScene("courtroomdialog");
    }
}
