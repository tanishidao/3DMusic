using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Don : MonoBehaviour
{
    /// <summary>
    /// don�������X�N���v�g
    /// </summary>

    public float MoveSpeed ;
    void Update()
    {
        transform.Translate(0, 0, MoveSpeed * Time.deltaTime);
    }
}
