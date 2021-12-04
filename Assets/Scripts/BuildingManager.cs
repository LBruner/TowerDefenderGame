using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BuildingManager : MonoBehaviour
{
    public static BuildingManager Instance { get; private set; }
    private Camera mainCamera;
    private BuldingTypeSO activeBuildingType;
    private BuldingTypeListSO buildingTypeList;

    private void Awake()
    {
        Instance = this;
        buildingTypeList = Resources.Load<BuldingTypeListSO>(typeof(BuldingTypeListSO).Name);
        activeBuildingType = null;
    }

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            if (activeBuildingType != null)
                Instantiate(activeBuildingType.prefab, GetMouseWorldPosition(), Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetBuildingType(buildingTypeList.list[0]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetBuildingType(buildingTypeList.list[1]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetBuildingType(buildingTypeList.list[2]);
        }

    }

    public void SetBuildingType(BuldingTypeSO newBuldingType)
    {
        activeBuildingType = newBuldingType;
    }

    public BuldingTypeSO GetActiveBuldingType()
    {
        return activeBuildingType;
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseWouldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWouldPosition.z = 0f;
        return mouseWouldPosition;
    }
}
