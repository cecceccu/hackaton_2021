using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{

    public bool isDragging;
    public GameObject prefab;
    public Vector3 mousePos;
    public Vector3 objectPos;


    public void OnMouseDown()
    {
        isDragging = true;
    }

    public void OnMouseUp()
    {
        isDragging = false;
        mousePos = Input.mousePosition;
        mousePos.z = Mathf.Abs(Camera.main.transform.position.z);
        objectPos = Camera.main.ScreenToWorldPoint(mousePos);
        Debug.Log(prefab);
        objectPos.z = 0f;
        Instantiate(prefab, objectPos, Quaternion.identity);
        prefab.SetActive(true);

    }

    void Update()
    {
        
        if (isDragging) {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        }
    }
}