using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class I1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 获取设备

        Keyboard keyboard = Keyboard.current;//键盘

        #endregion

        #region 单个按键 按下 抬起 按住

        //按下
        if (keyboard.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("spaceKey.wasPressedThisFrame");
        }

        //抬起
        if (keyboard.spaceKey.wasReleasedThisFrame)
        {
            Debug.Log("spaceKey.wasReleasedThisFrame");
        }

        //按住
        if (keyboard.spaceKey.isPressed)
        {
            Debug.Log("spaceKey.isPressed");
        }

        #endregion


        #region 通过事件监听

        keyboard.onTextInput += (ch) =>
        {
            Debug.Log("onTextInput:" + ch);
        };

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        //按下
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("spaceKey.wasPressedThisFrame");
        }

        //抬起
        if (Keyboard.current.spaceKey.wasReleasedThisFrame)
        {
            Debug.Log("spaceKey.wasReleasedThisFrame");
        }

        //按住
        if (Keyboard.current.spaceKey.isPressed)
        {
            Debug.Log("spaceKey.isPressed");
        }
    }
}
