using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DjamalDialogue : MonoBehaviour
{
    public int choix = 0;
    //bool de conversation
    public bool startConv, curConv, endConv;
    public bool part1 = true, partN, partY;
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
        if (Input.GetKeyDown(KeyCode.Y) && startConv == true)
        {
            yChoice();
            Debug.Log("nb y:" + choix);
        }
        if (Input.GetKeyDown(KeyCode.N) && startConv == true)
        {
            nChoice();
            Debug.Log("nb n:" + choix);
        }
        if (curConv == true)
        {
            dialogueUI.SetActive(true);
        }
        else
        {
            dialogueUI.SetActive(false);
        }
        if (part1 == true && partN == false && partY == false)
        {
            if (choix == 1)
            {
                mainText.text = MainY[0];//super ge ....
                textY.text = Y[1];
                textN.text = N[1];
                partY = true;
                choix = 0;
            }
            else if (choix == -1)
            {
                mainText.text = MainN[0]; // oh cest bi...
                textY.text = Y[1];
                textN.text = N[1];
                partN = true;
                choix = 0;
            }
        }
        //parti NON
        if (part1 == true && partN == true && partY == false)
        {
            mainText.text = MainN[0];
            textY.text = Y[2];
            textN.text = N[1];
            if (choix == 1)
            {
                mainText.text = MainN[1];
                textY.text = "";
                textN.text = "";
                endConv = true;
            }
            else if (choix == -1)
            {
                mainText.text = MainN[2];
                textY.text = "";
                textN.text = "";
                endConv = true;
            }
        }
        //Parti Oui
        if (part1 == true && partN == false && partY == true)
        {
            mainText.text = MainY[0] + "." + MainY[1];
            mainText.fontSize = 14;
            textY.text = Y[3];
            textN.text = N[2];
            if (choix == 1)
            {
                mainText.fontSize = 16;
                mainText.text = MainY[2];
                textY.text = "";
                textN.text = "";
                endConv = true;
            }
            else if (choix == -1)
            {
                mainText.text = MainY[3];
                textY.text = "";
                textN.text = "";
                endConv = true;
            }
        }
    }

    public void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            startConv = true;
            curConv = true;
            part1 = true;
            mainText.text = Main[0];
            textY.text = Y[0];
            textN.text = N[0];

        }
    }

    public void OnTriggerExit(Collider other)
    {
        startConv = false;
        curConv = false;
    }

    public void yChoice()
    {
        choix = 1;
    }
    public void nChoice()
    {
        choix = -1;
    }
}
