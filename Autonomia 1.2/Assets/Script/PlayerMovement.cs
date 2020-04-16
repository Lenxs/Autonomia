using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float speed, sensiX =3f, sensiY=3f;//sensibilite de rotation

    PlayerMotor motor;

    [SerializeField]
    bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        motor = GetComponent<PlayerMotor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            //calcule de velocite de movement du joueur
            float _xMove = Input.GetAxisRaw("Horizontal");
            /*
             -1 = gauche
             0 = bouge pas
             1 = droite
             */
            float _zMove = Input.GetAxisRaw("Vertical");

            Vector3 _moveHorizontal = transform.right * _xMove;
            Vector3 _moveVertical = transform.forward * _zMove;

            Vector3 _velocity = (_moveHorizontal + _moveVertical).normalized * speed;

            motor.Move(_velocity);

            // on va calculerla rotation  du joueur 
            float _yRot = Input.GetAxisRaw("Mouse X");

            Vector3 _rotation = new Vector3(0, _yRot, 0) * sensiX;

            motor.Rotate(_rotation);

            // on va calculer la rotation de la camera
            float _xRot = Input.GetAxisRaw("Mouse Y");

            float _cameraRotationX = _xRot * sensiY;

            motor.RotateCamera(_cameraRotationX);

        }
    }
}
