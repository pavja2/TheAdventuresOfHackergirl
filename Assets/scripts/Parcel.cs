using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Parcel : MonoBehaviour {
	static int scoreNumber;
	static float speed;
	public double startX;
	public double startY;
	public SpriteRenderer colormesh;
	public GameObject scoreText;
	string[] parcelTypes = new string[3]{"red", "green", "blue"};
    string[] parcelDests = new string[3] { "real", "fake", "real" };
    string[] parcelDirections = new string[2] { "coming", "going" };
    string[] badParcelSprites = new string[5] { "fakeimg1", "fakeimg2", "fakeimg3", "fakeimg4", "fakeimg6" };
    string goodSpriteComing = "realimg2";
    string goodSpriteGoing = "realimg1";
    Color[] parcelColors = new Color[3]{new Color(1, 0, 0, .75f), new Color(0, 1, 0, .75f), new Color(0, 0, 1, .75f)};
    string parcelType;
    string parcelDest;
    string parcelDirection;

	// Use this for initialization
	void Start () {
		Parcel.speed = 0.02f;
		Parcel.scoreNumber = 0;
        scoreText.GetComponent<Text>().text = "Letters Collected: " + scoreNumber;
        int randint = Random.Range(0, 3);
	    parcelType = parcelTypes[randint];
        int randint2 = Random.Range(0, 3);
        parcelDest = parcelDests[randint2];
		colormesh.color = parcelColors [randint];
        int randint3 = Random.Range(0, 2);
        parcelDirection = parcelDirections[randint3];
        int randint4 = Random.Range(0, 4);
        if(parcelDest == "real")
        {
            if(parcelDirection == "going")
            {
                this.GetComponent<SpriteRenderer>().sprite = Resources.Load("realimg1", typeof(Sprite)) as Sprite;
            }
            else
            {
                this.GetComponent<SpriteRenderer>().sprite = Resources.Load("realimg2", typeof(Sprite)) as Sprite;
            }
        }
        else
        {
            string fakeval = badParcelSprites[randint4];
            this.GetComponent<SpriteRenderer>().sprite = Resources.Load(fakeval, typeof(Sprite)) as Sprite;
        }
		startX = this.transform.position.x;
		startY = this.transform.position.y;
		generateCoordinates();
	}

	void OnMouseDown(){
		generateCoordinates();
        if ((parcelType == "red" && parcelDest == "real" && parcelDirection == "going") || (parcelType == "blue" && parcelDest == "real"))
        {
            scoreNumber = scoreNumber + 1;
            scoreText.GetComponent<Text>().text = "Letters Collected: " + scoreNumber;
            if (scoreNumber > 2)
            {
                SceneManager.LoadScene("transition_3");
            }
            else
            {
                int randint = Random.Range(0, 3);
                parcelType = parcelTypes[randint];
                int randint2 = Random.Range(0, 3);
                parcelDest = parcelDests[randint2];
                colormesh.color = parcelColors[randint];
                int randint3 = Random.Range(0, 2);
                parcelDirection = parcelDirections[randint3];
                int randint4 = Random.Range(0, 4);
                if (parcelDest == "real")
                {
                    if (parcelDirection == "going")
                    {
                        this.GetComponent<SpriteRenderer>().sprite = Resources.Load("realimg1", typeof(Sprite)) as Sprite;
                    }
                    else
                    {
                        this.GetComponent<SpriteRenderer>().sprite = Resources.Load("realimg2", typeof(Sprite)) as Sprite;
                    }
                }
                else
                {
                    string fakeval = badParcelSprites[randint4];
                    this.GetComponent<SpriteRenderer>().sprite = Resources.Load(fakeval, typeof(Sprite)) as Sprite;
                }
            }
        }
        else
        {
            SceneManager.LoadScene("packagegameover");
        }
	}
	

	// Update is called once per frame
	void Update () {
		if(this.transform.position.y < -2.7){
            int randint = Random.Range(0, 3);
            parcelType = parcelTypes[randint];
            int randint2 = Random.Range(0, 3);
            parcelDest = parcelDests[randint2];
            colormesh.color = parcelColors[randint];
            int randint3 = Random.Range(0, 2);
            parcelDirection = parcelDirections[randint3];
            int randint4 = Random.Range(0, 4);
            if (parcelDest == "real")
            {
                if (parcelDirection == "going")
                {
                    this.GetComponent<SpriteRenderer>().sprite = Resources.Load("realimg1", typeof(Sprite)) as Sprite;
                }
                else
                {
                    this.GetComponent<SpriteRenderer>().sprite = Resources.Load("realimg2", typeof(Sprite)) as Sprite;
                }
            }
            else
            {
                string fakeval = badParcelSprites[randint4];
                this.GetComponent<SpriteRenderer>().sprite = Resources.Load(fakeval, typeof(Sprite)) as Sprite;
            }
            generateCoordinates();
		}
		else{
			transform.Translate(0, -1 * Parcel.speed, 0);
		}
	}

	void generateCoordinates(){
		transform.position = new Vector3 ((float)(startX), (float)(startY + Random.Range (0f, 2.75f)), 0f);
	}
}