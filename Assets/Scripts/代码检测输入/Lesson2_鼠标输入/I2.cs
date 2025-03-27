using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class I2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 获取鼠标输入

        Mouse mouse = Mouse.current;

        #endregion

        #region 鼠标的 按下 抬起 按住

        //鼠标左键
        //mouse.leftButton

        //鼠标右键
        //mouse.rightButton

        //鼠标中键
        //mouse.middleButton

        //鼠标的前进按钮
        //mouse.forwardButton
        //鼠标的后退按钮
        //mouse.backButton

        if (mouse.leftButton.wasPressedThisFrame)
        {
            Debug.Log("鼠标左键按下");
        }

        #endregion

        #region 获取鼠标的位置

        //获取鼠标的位置
        //mouse.position.ReadValue()

        //得到两帧之间的向量
        //mouse.delta.ReadValue()   

        //得到鼠标的滚轮滚动值
        //mouse.scroll.ReadValue()

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
