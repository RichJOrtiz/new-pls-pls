using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public bool sim;
    public string[] sentences;
    public string[] datingsimprompts;
    public string[] answerchoices;
    public string[] correctanswers;
    public string[] correctreply;

    public GameObject arvin;
    private int index;

    private int simindex;
    public float typingspeed;
    private AudioSource source;

    string answer;
    public GameObject choice1;
    public GameObject choice2;
    public GameObject choice3;
    public GameObject continueButton;
    public GameObject failure;

    public Sprite[] sprites;
       


    private void Start()
    {
        source = GetComponent<AudioSource>();
        StartCoroutine(Type());

        choice1.SetActive(false);
        choice2.SetActive(false);
        choice3.SetActive(false);
        failure.SetActive(false);
        simindex = 0;

    }

    private void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    public void changearvin()
    {
        int randomarvin = Random.Range(0, sprites.Length);
        arvin.GetComponent<SpriteRenderer>().sprite = sprites[randomarvin];
    }
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingspeed);
        }
        
    }

    IEnumerator Typevisual(string [] arr,int index1)
    {
        foreach (char letter in arr[index1].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingspeed);
        }

    }

    IEnumerator Wait()
    {
        /*
        yield return new WaitForSeconds(1f);

        while (answer!=0)
        {
            Debug.Log("please choose a choice");
            Debug.Log(answer);
        }


        if(answer!=0)
        {
            dolast();
        }
        */

        return null;

    }



    public void buttonname()
    {
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);
    }

    public void NextSentence()
    {
        source.Play();
        changearvin();
        continueButton.SetActive(false);
        if (index <sentences.Length-1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());

        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);

            if(sim==true)
            visualnovel();
        }
    }

    public void visualnovel()
    {

        Debug.Log("runnig");
        StartCoroutine(Typevisual(datingsimprompts, simindex));
        choice1.SetActive(true);
        choice2.SetActive(true);
        choice3.SetActive(true);
        
        answer = "0";
        //StartCoroutine(Wait());
        //Debug.Log("THIS IS THE CURRENT ANSWER" + answer);

        /*
        if(answer !=correctanswers[0])
        {
            failure.SetActive(true);
            choice1.SetActive(false);
            choice2.SetActive(false);
            choice3.SetActive(false);

        }
        else
        {
            Debug.Log("YOU GOT THE CORRECT ANSWER");
            StartCoroutine(Typevisual(correctreply, 0));
        }
        */
        //StartCoroutine(WaitForAnswer());


    }

    public void buttonchoice()
    {
        answer = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(answer);
        if (answer != correctanswers[simindex])
        {
            Debug.Log("YOU did not have THE CORRECT ANSWER");

            failure.SetActive(true);
            choice1.SetActive(false);
            choice2.SetActive(false);
            choice3.SetActive(false);

        }
        else
        {
            Debug.Log("YOU GOT THE CORRECT ANSWER");
            choice1.SetActive(false);
            choice2.SetActive(false);
            choice3.SetActive(false);
            StartCoroutine(Typevisual(correctreply, simindex));
            //StartCoroutine(test());

            textDisplay.text = "";

            simindex++;
            visualnovel();
        }
    }

        IEnumerator test()
        {
            yield return new WaitForSeconds(4f);
        Debug.Log("waiting");
        }
    }



 

