using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public bool Placed { get; private set; }
    public BoundsInt area;

    #region Build Methods

    public bool CanBePlaced()
    {
        Vector3Int positionInt = GridBuildingSystem.current.gridLayout.LocalToCell(transform.positon);
        BoundsInt areaTemp = area;
        areaTemp.position = positionInt;
        if (GridBuildingSystem.current.CanTakeArea(areaTemp))
        {

        }
    }

    #endregion
}
