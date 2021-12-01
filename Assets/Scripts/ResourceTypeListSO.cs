using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/ResourceTypeListSO", order = 0)]
public class ResourceTypeListSO : ScriptableObject
{
    public List<ResourceTypeSO> list;
}