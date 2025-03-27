using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class L3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //在获取设备的输入时，最好先判断一次是否为空
        //这样可以避免在没有触摸屏的设备上报错
        Touchscreen ts = Touchscreen.current;
        if (ts != null)
        {
            return;
        }

        #region 获取手指的数量

        print("当前触摸屏上的手指数量：" + ts.touches.Count);

        //得到单个手指的信息0.
        foreach (TouchControl touch in ts.touches)
        {
            print("手指的位置：" + touch.position.ReadValue());
        }

        #endregion

        #region 获取手指的按下 抬起 按住

        //获取指定索引的手指
        TouchControl touch0 = ts.touches[0];

        //获取手指的按下状态
        if (ts.press.wasPressedThisFrame)
        {
            
        }

        //获取手指的抬起状态
        if (ts.press.wasReleasedThisFrame)
        {

        }

        //获取手指的按住状态
        if (ts.press.isPressed)
        {

        }

        #endregion


        #region 手指位置信息

        //位置
        print("手指的位置：" + touch0.position.ReadValue());
        //第一次按下的位置
        print("手指的按下位置：" + touch0.startPosition.ReadValue());
        //接触区域大小
        print("手指的接触区域大小：" + touch0.radius.ReadValue());
        //接触偏移位置
        print("手指的接触偏移位置：" + touch0.delta.ReadValue());

        //得到当前手指的状态
        print("当前手指的状态：" + touch0.phase.ReadValue());
        UnityEngine.InputSystem.TouchPhase touchPhase = touch0.phase.ReadValue();

        switch (touchPhase)
        {
            case UnityEngine.InputSystem.TouchPhase.None:
                print("没有触摸");
                break;
            case UnityEngine.InputSystem.TouchPhase.Began:
                print("手指刚刚按下");
                break;
            case UnityEngine.InputSystem.TouchPhase.Ended:
                print("手指刚刚抬起");
                break;
            case UnityEngine.InputSystem.TouchPhase.Moved:
                print("手指在移动");
                break;
            case UnityEngine.InputSystem.TouchPhase.Stationary:
                print("手指在按住");
                break;
            case UnityEngine.InputSystem.TouchPhase.Canceled:
                print("手指的状态被取消");
                break;

        }


        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
