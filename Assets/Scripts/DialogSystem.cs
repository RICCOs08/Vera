using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{
    public string[] lines;
    public float speed;
    public Text dilogueText;

    public int index;

    
    void Start()
    {
        dilogueText.text = string.Empty;
        
    }

    
    void Update()
    {
        
    }

    public void StartDialogue()
    {
        index = 0;

        
    }

    IEnumerator Typeline()
    {
        foreach(char c in lines[index].ToCharArray())
        {
            dilogueText.text += c;
            yield return new WaitForSeconds(speed);
        }
    }

    public void SkipText()
    {
        if(dilogueText.text == lines[index])
        {
            NextLines();
        }
        else
        {
            StopAllCoroutines();
            dilogueText.text = lines[index];

        }
    }

    public void NextLines()
    {
        if(index < lines.Length - 1)
        {
            index++;
            dilogueText.text = string.Empty;
            StartCoroutine(Typeline());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

}
