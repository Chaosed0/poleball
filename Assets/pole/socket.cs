using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class socket : MonoBehaviour
{
    private void Awake()
    {
        transform.localRotation = Quaternion.LookRotation(-transform.localPosition);
    }
}
