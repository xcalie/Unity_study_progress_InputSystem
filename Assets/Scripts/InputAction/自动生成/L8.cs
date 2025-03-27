using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 引入InputAction

        // 引入InputAction
        L7 input = new L7();

        // 启用InputAction
        input.Enable();

        // 监听
        input.Action1.Move.performed += ctx =>
        {
            Debug.Log("Move");
        };


        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
