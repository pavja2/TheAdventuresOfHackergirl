using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Encryption : MonoBehaviour {

    public static int messageSwitch;
    public GameObject puppyText;
	// Use this for initialization
	void Start () {
        messageSwitch = 0;
        puppyText.GetComponent<Text>().text = "MSG:";

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    


    public void OnMatchFound()
    {
        this.GetComponent<SpriteRenderer>().color = new Color(0, .5f, 0, .8f);
    }

    public void UpdateMessage()
    {
        messageSwitch++;
        switch (messageSwitch)
        {
            case 1:
                puppyText.GetComponent<Text>().text = "MSG: I ---- the ------- locked in --- ---- -----. -------- will ----- find ----!";
                break;
            case 2:
                puppyText.GetComponent<Text>().text = "MSG: I ---- the ------- locked in --- ---- -----. Hackergirl will never find them!";
                break;
            case 3:
                puppyText.GetComponent<Text>().text = "MSG: I ---- the puppies locked in --- ---- -----. Hackergirl will never find them!";
                break;
            case 4:
                puppyText.GetComponent<Text>().text = "MSG: I have the puppies locked in the North Tower. Hackergirl will never find them!";
                StartCoroutine(Wait());
                SceneManager.LoadScene("penultimate_scene");
                break;
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);

    }

}
