using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Resources: https://gist.github.com/gunderson/d7f096bd07874f31671306318019d996
 */

public class Movement : MonoBehaviour
{
    //Change The speed multiplier as playable space increases
    float movementSpeed = 10.0f; //player movement speed
    float boostMovement = 25.0f; //Aka running space
    float maxMovementSpeed = 100.0f; //Top speed of player

    //Camera Settings
    float cameraMovementSpeed = 0.20f; //Mouse Sensitifity
    private Vector3 lastMouse = new Vector3(255, 255, 255); //Inital Camera Place
    bool cursorState;

    private float total = 1.0f;

    private void Start() {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
        cursorState = true;        
    }

    void Update() {
        //Camera movement by mouse 
        lastMouse = Input.mousePosition - lastMouse;
        lastMouse = new Vector3(-lastMouse.y * cameraMovementSpeed, lastMouse.x * cameraMovementSpeed, 0);
        lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x, transform.eulerAngles.y + lastMouse.y, 0);
        transform.eulerAngles = lastMouse;
        lastMouse = Input.mousePosition;
         
        //Keyboard command logics
        Vector3 position = GetInput();
        if(Input.GetKey(KeyCode.LeftShift)) {
            total += Time.deltaTime;
            position = position * total * boostMovement;
            position.x = Mathf.Clamp(position.x, -maxMovementSpeed, maxMovementSpeed);
            position.y = Mathf.Clamp(position.y, -maxMovementSpeed, maxMovementSpeed);
            position.z = Mathf.Clamp(position.z, -maxMovementSpeed, maxMovementSpeed);
        }else {
            total = Mathf.Clamp(total * 0.5f, 1f, 1000f);
            position = position * movementSpeed;
        }

        if (Input.GetKey(KeyCode.LeftAlt)) {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            //GetComponent(lastMouse).enable = false;
            cursorState = false;
        } else if(Input.GetKey(KeyCode.Mouse0)) {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Confined;
            cursorState = true;
        }

        position = position * Time.deltaTime;
        transform.Translate(position);
    }

    //Gets player inputs
    private Vector3 GetInput() { 
        Vector3 positionVelocity = new Vector3();
        if(Input.GetKey(KeyCode.W)) {
            positionVelocity += new Vector3(0, 0, 1);
        }
        if(Input.GetKey(KeyCode.S)) {
            positionVelocity += new Vector3(0, 0, -1);
        }
        if(Input.GetKey(KeyCode.A)) {
            positionVelocity += new Vector3(-1, 0, 0);
        }
        if(Input.GetKey(KeyCode.D)) {
            positionVelocity += new Vector3(1, 0, 0);
        }
        if(Input.GetKey(KeyCode.D)) {
            positionVelocity += new Vector3(1, 0, 0);
        }
        if(Input.GetKey(KeyCode.LeftControl)) {
            positionVelocity += new Vector3(0, -1, 0);
        }
        if(Input.GetKey(KeyCode.Space)) {
            positionVelocity += new Vector3(0, 1, 0);
        }
        return positionVelocity;
    }
}
