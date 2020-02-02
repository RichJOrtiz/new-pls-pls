using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class choice : MonoBehaviour
{

    public GameObject textbox;
    public GameObject choice1;
    public GameObject choice2;
    public GameObject choice3;
    public int choicemade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void choiceoption1()
    {
        textbox.GetComponent<Text>().text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
