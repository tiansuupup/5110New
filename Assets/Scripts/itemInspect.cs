using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemInspect : MonoBehaviour
{   
    public Camera playerCam;
    GameObject clickedObject;

    Vector3 originalPoistion;
    Vector3 originalRotation;

    bool isInspecting;

    // Start is called before the first frame update
    void Start()
    {
        //playerCam = Camera.FPS;
        isInspecting = false;
    }

    // Update is called once per frame
    void Update()
    {
        clickObject();
        InspectObject();
        ExitInspect();        
    }

    void clickObject()
    {
        if(Input.GetMouseButtonDown(0) && isInspecting == false)
        {
            RaycastHit hit;
            Ray ray = playerCam.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                clickedObject = hit.transform.gameObject;

                originalPoistion = clickedObject.transform.position;
                originalRotation = clickedObject.transform.rotation.eulerAngles;

                clickedObject.transform.position = playerCam.transform.position + (transform.forward * 3f);

                Time.timeScale = 0;

                isInspecting = true;
            }
        }
    }

    void InspectObject()
    {
        if(Input.GetMouseButtonDown(0) && isInspecting)
        {
            float rotateSpeed = 15f;

            float xAxis = Input.GetAxis("Mouse X") * rotateSpeed;
            float yAxis = Input.GetAxis("Mouse Y") * rotateSpeed;

            clickedObject.transform.Rotate(Vector3.up, -xAxis, Space.World);
            clickedObject.transform.Rotate(Vector3.right, yAxis, Space.World);
        }
    }

    void ExitInspect()
    {
        if(Input.GetMouseButtonDown(1) && isInspecting)
        {
            clickedObject.transform.position = originalPoistion;
            clickedObject.transform.eulerAngles = originalRotation;

            Time.timeScale = 1;

            isInspecting = false;
        }
    }
}
