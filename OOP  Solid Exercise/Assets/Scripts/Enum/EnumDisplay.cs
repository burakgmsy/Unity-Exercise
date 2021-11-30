using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumDisplay : MonoBehaviour
{
    public WeaponType type;
    private void Start()
    {
        Debug.Log($"{(int)EnumExample.EXAMPLE}-{(int)EnumExample.ANOTHER_EXAMPLE}-{(int)EnumExample.THIRD_EXAMPLE}");
        Debug.Log($"{EnumExample.EXAMPLE}-{EnumExample.ANOTHER_EXAMPLE}-{EnumExample.THIRD_EXAMPLE}");
    }
}
