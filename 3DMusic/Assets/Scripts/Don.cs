using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Don : MonoBehaviour
{
    /// <summary>
    /// donが動くスクリプト
    /// </summary>

    public float MoveSpeed ;
    void Update()
    {
        transform.Translate(0, 0, MoveSpeed * Time.deltaTime);
    }
}
