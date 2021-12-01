using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObjects/BuldingTypeList", menuName = "ScriptableObjects/BuldingTypeList", order = 0)]
public class BuldingTypeListSO : ScriptableObject
{
    public List<BuldingTypeSO> list;
}