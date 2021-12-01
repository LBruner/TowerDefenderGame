using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance { get; private set; }

    private Dictionary<ResourceTypeSO, int> resourceAmountDictionary;

    private void Awake()
    {
        Instance = this;

        resourceAmountDictionary = new Dictionary<ResourceTypeSO, int>();

        ResourceTypeListSO resourceTypeList = Resources.Load<ResourceTypeListSO>(typeof(ResourceTypeListSO).Name);

        foreach (ResourceTypeSO resourceType in resourceTypeList.list)
        {
            resourceAmountDictionary.Add(resourceType, 0);
        }
        TestLogResources();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ResourceTypeListSO resourceTypeList = Resources.Load<ResourceTypeListSO>(typeof(ResourceTypeListSO).Name);
            AddResource(resourceTypeList.list[0], 5);
        }
        TestLogResources();
    }

    private void TestLogResources()
    {
        foreach (KeyValuePair<ResourceTypeSO, int> resourceType in resourceAmountDictionary)
        {
            Debug.Log(resourceType.Key + ": " + resourceType.Value);
        }
    }

    public void AddResource(ResourceTypeSO type, int amount)
    {
        resourceAmountDictionary[type] += amount;
    }
}
