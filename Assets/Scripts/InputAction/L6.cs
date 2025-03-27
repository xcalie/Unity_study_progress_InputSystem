using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class L6 : MonoBehaviour
{
    public InputAction Move;

    [Header("Move_Axis")]
    public InputAction Move_Axis;

    private void Start()
    {
        #region 输入检测

        //启用输入
        Move.Enable();

        //操作监听
        //开始操作
        Move.started += Func;

        //触发
        Move.performed += Func;

        //结束
        Move.canceled += Func;
        


        #endregion
    }

    private void Func(InputAction.CallbackContext context)
    {
        Debug.Log("Move.started");
        //当前状态
        //没有启用 Disabled
        //等待 Waiting
        //开始 Started
        //触发 Performed
        //结束 Canceled
        //context.phase
        Debug.Log(context.phase);

        //动作行为信息
        Debug.Log(context.action);

        //空间信息
        Debug.Log(context.control.name);

        //获取值
        //Debug.Log(context.ReadValue<Vector2>());

        //持续时间
        Debug.Log(context.duration);

        //开始时间
        Debug.Log(context.startTime);
    }
}
