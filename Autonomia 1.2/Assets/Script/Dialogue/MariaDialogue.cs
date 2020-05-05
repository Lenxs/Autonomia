using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MariaDialogue : MonoBehaviour
{
    //dial sans reel choix
    public int choix = 0;
    //bool de conversation
    public bool startConv, curConv, endConv;
    public bool part1 = true, po1,po2, pn1, f1, f2;
    //public int i, j, k;// i main,j y
    //dialogue UI
    public GameObject DialogueUI;
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
        }
        if (Input.GetKeyDown(KeyCode.N) && startConv == true)
        {
            nChoice();
        }
        if (curConv == true)
        {
            DialogueUI.SetActive(true);
        }
        else
        {
            DialogueUI.SetActive(false);
        }
        if (part1 == true && po1 == false && pn1 == false)//juste changer les valeur
        {
            if (choix == 1)
            {
                mainText.text = MainY[0];//bien bonne
                textY.text = Y[2];
                textN.text = N[2];
                po1 = true;
                choix = 0;
            }
            else if (choix == -1)
            {
                mainText.text = MainN[0]; // ok tant mieux ...
                textY.text = Y[1];
                textN.text = N[1];
                pn1 = true;
                choix = 0;
            }
        }
        //parti oui 1
        if (part1 == true && po1 == true && pn1 == false && po2==false)
        {
            mainText.text = MainY[0];//bien bonne ....
            textY.text = Y[2];
            textN.text = N[2];
            if (choix == 1)
            {
                mainText.text = Main[1];//tu peux ...
                textY.text = Y[3];
                textN.text = N[3];
                po2 = true;
                choix = 0;

            }
            else if (choix == -1)
            {
                mainText.text = Main[1];
                textY.text = Y[3];
                textN.text = N[3];
                po2 = true;
                choix = 0;

            }
           
        }
        //oui part 2
        if (part1 == true && po2 == true && po1 == true && pn1 == false)
        {
            mainText.text = Main[1];
            textY.text = Y[3];
            textN.text = N[3];
            if (choix == 1)
            {
                mainText.text = "Incendie";
                textY.text = "";
                textN.text = "";
                f1 = true;
                endConv = true;
                choix = 0;

            }
            else if (choix == -1)
            {
                mainText.text = "Incendie";
                textY.text = "";
                textN.text = "";
                f2 = true;
                endConv = true;
                choix = 0;

            }
        }
        //Parti non
        if (part1 == true && po1 == false && pn1 == true && f1 == false && f2 == false)
        {
            mainText.text = MainN[0];//tu rep ...
            textY.text = Y[1];
            textN.text = N[1];
            if (choix == 1)
            {
                mainText.text = MainY[0];//bien bonne ....
                textY.text = Y[2];
                textN.text = N[2];
                po1 = true;
                pn1 = false;
                choix = 0;

            }
            else if (choix == -1)
            {
                mainText.text = MainY[0];//bien bonne ....
                textY.text = Y[2];
                textN.text = N[2];
                po1 = true;
                pn1 = false;
                choix = 0;

            }

        }
        if (part1 == true && po1 ==true && po2==true && f1 ==true || f2==true)
        {
            mainText.text = "Incendie";
            textY.text = "";
            textN.text = "";
            endConv = true;
        }
        
    }

    public void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            startConv = true;
            curConv = true;
            part1 = true;
            mainText.text = Main[0];// tu aurais ...
            textY.text = Y[0] + "[Y]*Blague*";
            textN.text = N[0] + "[N]";

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
