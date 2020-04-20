using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
    public int choiceY = 0,choiceN=0;
    //bool de conversation
    public bool startConv,curConv, endConv;
    public bool part1 =true, part2, part3;
    //public int i, j, k;// i main,j y
    //dialogue UI
    public GameObject dialogueUI;
    public Text mainText, textY, textN;
    public string[] Main, MainY, MainN, Y, N;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y)&&startConv==true)
        {
            yChoice();
            Debug.Log("nb y:" + choiceY);
        }
        if(Input.GetKeyDown(KeyCode.N)&&startConv==true)
        {
            nChoice();
            Debug.Log("nb n:" + choiceN);
        }
        if (curConv == true)
        {
            dialogueUI.SetActive(true);
        }
        else
        {
            dialogueUI.SetActive(false);
        }
        while (part1 == true && part2 == false && part3 == false)
        {
            if (choiceY == 1)
            {
                mainText.text = MainY[0];
                textY.text = Y[1];
                textN.text = N[1];
            }
        }
    }

    public void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            startConv = true;
            curConv = true;
            mainText.text = Main[0];
            textY.text = Y[0];
            textN.text = N[0];
            
        }
    }

    public void OnTriggerExit(Collider other)
    {
        startConv = false;
    }

    public void yChoice()
    {
        choiceY++;
    }
    public void nChoice()
    {
        choiceN++;
    }
}
