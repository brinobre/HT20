using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    public void GrowCube()
    {
        transform.localScale *= 1.1f;
    }
}
