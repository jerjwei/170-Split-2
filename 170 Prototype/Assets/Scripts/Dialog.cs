using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject continueButton;
    public GameObject Dialogbox;
    public Rigidbody2D rb;

    void Start()
    {
        StartCoroutine(Type());
    }

    private void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
            
        }
    }

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);
        
        if (index < sentences.Length - 1)
        {

            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
        }
        else{
            textDisplay.text = "";
            continueButton.SetActive(false);
            rb.constraints = RigidbodyConstraints2D.None;
            Dialogbox.SetActive(false);
        }
    }

}
