using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{

    //public Camera cam;
   // public GameObject turtle;
    public float speedCam,speedTurtle;
    void Update()
    {
       transform.Translate(Vector3.forward * speedTurtle);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        Invoke("Next", 56.5f);
    }

    void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
