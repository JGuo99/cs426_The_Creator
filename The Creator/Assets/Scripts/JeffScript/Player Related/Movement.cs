using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Resources: 
 * Camera Mouse Calculation: https://gist.github.com/gunderson/d7f096bd07874f31671306318019d996
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

    public Camera mainCamera;
    public Camera mouseCamera;
    public Camera starCamera;
    public Camera gasCamera;
    public Camera terraCamera;
    public Camera lavaCamera;
    public Camera cometCamera;

    bool onMainCamera;

    //Inital starting state of cursor
    private void Start() {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
        cursorState = true;

        onMainCamera = false;
        /*
        mainCamera.GetComponent<AudioListener>().enabled = mainCamera.GetComponent<AudioListener>().enabled;
        starCamera.GetComponent<AudioListener>().enabled = !starCamera.GetComponent<AudioListener>().enabled;
        gasCamera.GetComponent<AudioListener>().enabled = !gasCamera.GetComponent<AudioListener>().enabled;
        terraCamera.GetComponent<AudioListener>().enabled = !terraCamera.GetComponent<AudioListener>().enabled;
        lavaCamera.GetComponent<AudioListener>().enabled = !lavaCamera.GetComponent<AudioListener>().enabled;
        cometCamera.GetComponent<AudioListener>().enabled = !cometCamera.GetComponent<AudioListener>().enabled;
        */
        mainCamera.enabled = true;
        mouseCamera.enabled = false;
        starCamera.enabled = false;
        gasCamera.enabled = false;
        terraCamera.enabled = false;
        lavaCamera.enabled = false;
        cometCamera.enabled = false;
    }

    void Update() {
        if (cursorState)
        {
            //Camera movement by mouse 
            lastMouse = Input.mousePosition - lastMouse;
            lastMouse = new Vector3(-lastMouse.y * cameraMovementSpeed, lastMouse.x * cameraMovementSpeed, 0);
            lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x, transform.eulerAngles.y + lastMouse.y, 0);
            transform.eulerAngles = lastMouse;
            lastMouse = Input.mousePosition;
        }

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

        position = position * Time.deltaTime;
        transform.Translate(position);

        //Mouse Deteching
        if (Input.GetKey(KeyCode.Tab))
        {
            cursorState = !cursorState;
            toggleMouse();
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "StarTag")
                {
                    Debug.Log("Star Clicked");
                    switchStarCamera();
                }
                if (hit.transform.tag == "GasTag")
                {
                    Debug.Log("Gas Clicked");
                    switchGasCamera();
                }
                if (hit.transform.tag == "TerraTag")
                {
                    Debug.Log("Terra Clicked");
                    switchTerraCamera();
                }
                if (hit.transform.tag == "LavaTag")
                {
                    Debug.Log("Lava Clicked");
                    switchLavaCamera();
                }
                if (hit.transform.tag == "CometTag")
                {
                    Debug.Log("Comet Clicked");
                    switchCometCamera();
                }
            }
        }
    }

    private void toggleMouse()
    {
        if (cursorState)
        {
            switchMouseCamera();
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            switchMainCamera();
            Cursor.lockState = CursorLockMode.Confined;
        }
        Cursor.visible = !cursorState;
    }

    //Gets player inputs
    private Vector3 GetInput() { 
        Vector3 positionVelocity = new Vector3();
        if(Input.GetKey(KeyCode.W)) {
            positionVelocity += new Vector3(0, 0, 1);

            if (!onMainCamera)
                switchMainCamera();
        }
        if(Input.GetKey(KeyCode.S)) {
            positionVelocity += new Vector3(0, 0, -1);

            if (!onMainCamera)
                switchMainCamera();
        }
        if(Input.GetKey(KeyCode.A)) {
            positionVelocity += new Vector3(-1, 0, 0);

            if (!onMainCamera)
                switchMainCamera();
        }
        if(Input.GetKey(KeyCode.D)) {
            positionVelocity += new Vector3(1, 0, 0);

            if (!onMainCamera)
                switchMainCamera();
        }
        if(Input.GetKey(KeyCode.D)) {
            positionVelocity += new Vector3(1, 0, 0);

            if (!onMainCamera)
                switchMainCamera();
        }
        if(Input.GetKey(KeyCode.LeftControl)) {
            positionVelocity += new Vector3(0, -1, 0);

            if (!onMainCamera)
                switchMainCamera();
        }
        if(Input.GetKey(KeyCode.Space)) {
            positionVelocity += new Vector3(0, 1, 0);

            if (!onMainCamera)
                switchMainCamera();
        }


        return positionVelocity;
    }

    private void switchMainCamera()
    {
        onMainCamera = true;

        starCamera.GetComponent<AudioListener>().enabled = false;
        gasCamera.GetComponent<AudioListener>().enabled = false;
        terraCamera.GetComponent<AudioListener>().enabled = false;
        lavaCamera.GetComponent<AudioListener>().enabled = false;
        cometCamera.GetComponent<AudioListener>().enabled = false;
        mainCamera.GetComponent<AudioListener>().enabled = true;

        mainCamera.enabled = true;
        mouseCamera.enabled = false;
        starCamera.enabled = false;
        gasCamera.enabled = false;
        terraCamera.enabled = false;
        lavaCamera.enabled = false;
        cometCamera.enabled = false;
    }

    private void switchStarCamera()
    {
        onMainCamera = false;

        mainCamera.enabled = false;
        mouseCamera.enabled = false;
        starCamera.enabled = true;
        gasCamera.enabled = false;
        terraCamera.enabled = false;
        lavaCamera.enabled = false;
        cometCamera.enabled = false;

        mainCamera.GetComponent<AudioListener>().enabled = false;
        gasCamera.GetComponent<AudioListener>().enabled = false;
        terraCamera.GetComponent<AudioListener>().enabled = false;
        lavaCamera.GetComponent<AudioListener>().enabled = false;
        cometCamera.GetComponent<AudioListener>().enabled = false;
        starCamera.GetComponent<AudioListener>().enabled = true;
    }

    private void switchGasCamera()
    {
        onMainCamera = false;

        mainCamera.GetComponent<AudioListener>().enabled = false;
        starCamera.GetComponent<AudioListener>().enabled = false;
        terraCamera.GetComponent<AudioListener>().enabled = false;
        lavaCamera.GetComponent<AudioListener>().enabled = false;
        cometCamera.GetComponent<AudioListener>().enabled = false;
        gasCamera.GetComponent<AudioListener>().enabled = true;

        mainCamera.enabled = false;
        mouseCamera.enabled = false;
        starCamera.enabled = false;
        gasCamera.enabled = true;
        terraCamera.enabled = false;
        lavaCamera.enabled = false;
        cometCamera.enabled = false;
    }

    private void switchTerraCamera()
    {
        onMainCamera = false;

        mainCamera.enabled = false;
        mouseCamera.enabled = false;
        starCamera.enabled = false;
        gasCamera.enabled = false;
        terraCamera.enabled = true;
        lavaCamera.enabled = false;
        cometCamera.enabled = false;

        mainCamera.GetComponent<AudioListener>().enabled = !mainCamera.GetComponent<AudioListener>().enabled;
        starCamera.GetComponent<AudioListener>().enabled = !starCamera.GetComponent<AudioListener>().enabled;
        gasCamera.GetComponent<AudioListener>().enabled = !gasCamera.GetComponent<AudioListener>().enabled;
        lavaCamera.GetComponent<AudioListener>().enabled = !lavaCamera.GetComponent<AudioListener>().enabled;
        cometCamera.GetComponent<AudioListener>().enabled = !cometCamera.GetComponent<AudioListener>().enabled;
        terraCamera.GetComponent<AudioListener>().enabled = !terraCamera.GetComponent<AudioListener>().enabled;
    }

    private void switchLavaCamera()
    {
        onMainCamera = false;

        mainCamera.enabled = false;
        mouseCamera.enabled = false;
        starCamera.enabled = false;
        gasCamera.enabled = false;
        terraCamera.enabled = false;
        lavaCamera.enabled = true;
        cometCamera.enabled = false;

        mainCamera.GetComponent<AudioListener>().enabled = !mainCamera.GetComponent<AudioListener>().enabled;
        starCamera.GetComponent<AudioListener>().enabled = !starCamera.GetComponent<AudioListener>().enabled;
        gasCamera.GetComponent<AudioListener>().enabled = !gasCamera.GetComponent<AudioListener>().enabled;
        terraCamera.GetComponent<AudioListener>().enabled = !terraCamera.GetComponent<AudioListener>().enabled;
        cometCamera.GetComponent<AudioListener>().enabled = !cometCamera.GetComponent<AudioListener>().enabled;
        lavaCamera.GetComponent<AudioListener>().enabled = !lavaCamera.GetComponent<AudioListener>().enabled;
    }

    private void switchCometCamera()
    {
        onMainCamera = false;

        mainCamera.enabled = false;
        mouseCamera.enabled = false;
        starCamera.enabled = false;
        gasCamera.enabled = false;
        terraCamera.enabled = false;
        lavaCamera.enabled = false;
        cometCamera.enabled = true;

        mainCamera.GetComponent<AudioListener>().enabled = !mainCamera.GetComponent<AudioListener>().enabled;
        starCamera.GetComponent<AudioListener>().enabled = !starCamera.GetComponent<AudioListener>().enabled;
        gasCamera.GetComponent<AudioListener>().enabled = !gasCamera.GetComponent<AudioListener>().enabled;
        terraCamera.GetComponent<AudioListener>().enabled = !terraCamera.GetComponent<AudioListener>().enabled;
        lavaCamera.GetComponent<AudioListener>().enabled = !lavaCamera.GetComponent<AudioListener>().enabled;
        cometCamera.GetComponent<AudioListener>().enabled = !cometCamera.GetComponent<AudioListener>().enabled;
    }

    private void switchMouseCamera()
    {
        onMainCamera = false;

        mainCamera.enabled = false;
        mouseCamera.enabled = true;
        starCamera.enabled = false;
        gasCamera.enabled = false;
        terraCamera.enabled = false;
        lavaCamera.enabled = false;
        cometCamera.enabled = false;
    }

}
