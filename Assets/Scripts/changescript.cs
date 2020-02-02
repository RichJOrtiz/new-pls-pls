using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescript : MonoBehaviour
{
    
    public GameObject counterpart;
    private bool fix;

    //cached materials from BRICK
    SceneLoader sceneload;
   

    // Start is called before the first frame update
    void Start()
    {
        sceneload = FindObjectOfType<SceneLoader>();  //from BRICK
        counterpart.GetComponent<Renderer>().enabled = true;
        this.GetComponent<Renderer>().enabled = false;
        //fix = false;
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        Debug.Log("clicked");
        GetComponent<AudioSource>().Play();
        if (this.GetComponent<Renderer>().enabled == true)
        {
          
            this.GetComponent<Renderer>().enabled = false;
            counterpart.GetComponent<Renderer>().enabled = true;
        }
        else
        {
            
            Debug.Log("clicked2");
            this.GetComponent<Renderer>().enabled = true;
            counterpart.GetComponent<Renderer>().enabled = false;
        }
        //this.GetComponent<Renderer>().enabled = false;
        //counterpart.GetComponent<Renderer>().enabled = true;
        //this.GetComponent<SpriteRenderer>().sprite = mySprite;

        if (GameObject.Find("1").GetComponent<Renderer>().enabled==true && GameObject.Find("2").GetComponent<Renderer>().enabled == true)
        {
            int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(CurrentSceneIndex + 1);
        }
    }
}
