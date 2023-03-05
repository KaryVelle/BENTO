using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Drag_prueba : MonoBehaviour
{
    Vector3 offset;
    public string destinationTag = "DropArea";
    public GameObject orden;
    public GameObject canvaWin, canvaLose;
 
    void OnMouseDown()
    {
        offset = transform.position - MouseWorldPosition();
        transform.GetComponent<Collider>().enabled = false;
    }
 
    void OnMouseDrag()
    {
        transform.position = MouseWorldPosition() + offset;
    }
 
    void OnMouseUp()
    {
        var rayOrigin = Camera.main.transform.position;
        var rayDirection = MouseWorldPosition() - Camera.main.transform.position;
        RaycastHit hitInfo;
        if(Physics.Raycast(rayOrigin, rayDirection, out hitInfo))
        {
            if(hitInfo.transform.tag == destinationTag)
            {
                transform.position = hitInfo.transform.position;
                //Debug.Log("aghh watefok");
                Verificar();
            }
        }
        transform.GetComponent<Collider>().enabled = true;
        
        
    }

    void Verificar()
    {
        if (gameObject.tag == orden.tag)
        {
            canvaWin.SetActive(true);
            Debug.Log("yipee");
        }
        else
        {
            Debug.Log("NOOOOOO");
            canvaLose.SetActive(true);
        }
    }
    Vector3 MouseWorldPosition()
    {
        var mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }
}
