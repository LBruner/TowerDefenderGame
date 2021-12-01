using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    private Camera mainCamera;
    private BuldingTypeSO buildingType;
    private BuldingTypeListSO buildingTypeList;

    private void Awake()
    {
        buildingTypeList = Resources.Load<BuldingTypeListSO>(typeof(BuldingTypeListSO).Name);
        buildingType = buildingTypeList.list[0];
    }

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(buildingType.prefab, GetMouseWorldPosition(), Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
            buildingType = buildingTypeList.list[0];

        if (Input.GetKeyDown(KeyCode.Alpha2))
            buildingType = buildingTypeList.list[1];

    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseWouldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWouldPosition.z = 0f;
        return mouseWouldPosition;
    }
}
