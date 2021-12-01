using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuldingManager : MonoBehaviour
{
    [SerializeField] private Transform pfWoodHarvester;

    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(pfWoodHarvester, GetMouseWorldPosition(), Quaternion.identity);
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseWouldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWouldPosition.z = 0f;
        return mouseWouldPosition;
    }
}
