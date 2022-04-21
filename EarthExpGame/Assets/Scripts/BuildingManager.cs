using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingManager : MonoBehaviour
{
    public GameObject[] objects;
    private GameObject pendingObject;

    private Vector3 pos;

    private RaycastHit hit;
    [SerializeField] private LayerMask layerMask;

    private float rotateAmount = 45;
    private Quaternion rotationY;

    public float gridSize;
    public bool canPlace = true;

    void Update()
    {

        if (pendingObject != null)
        {
            pendingObject.transform.position = pos;

            if (Input.touchCount > 0 && canPlace)
            {
                Touch touch = Input.GetTouch(0);
                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        PlaceObject();
                        break;
                    case TouchPhase.Moved:

                        break;
                    case TouchPhase.Ended:

                        break;
                }
            }

        }
    }

    public void PlaceObject()
    {
        pendingObject = null;
    }

    public void RotateObject()
    {
        pendingObject.transform.Rotate(Vector3.up, rotateAmount);
    }

    private void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 1000, layerMask))
        {
            pos = hit.point;
        }
    }

    public void SelectObject(int index)
    {
        pendingObject = Instantiate(objects[index], pos, transform.rotation);
    }

    float RoundToNearestGrid(float pos)
    {
        float xDiff = pos % gridSize;
        pos -= xDiff;
        if (xDiff > (gridSize / 2))
        {
            pos += gridSize;
        }
        return pos;
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
