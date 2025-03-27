using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class L4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 获取手柄

        Gamepad gamepad = Gamepad.current;
        if (gamepad == null)
        {
            return;
        }

        #endregion

        #region 手柄摇杆

        //摇杆方向
        //左摇杆
        Vector2 leftStick = gamepad.leftStick.ReadValue();
        //右摇杆
        Vector2 rightStick = gamepad.rightStick.ReadValue();

        //摇杆按下
        if (gamepad.leftStickButton.wasPressedThisFrame)
        {
            Debug.Log("左摇杆按下");
        }
        if (gamepad.rightStickButton.wasPressedThisFrame)
        {
            Debug.Log("右摇杆按下");
        }
        //抬起 按住 同理

        #endregion

        #region 手柄方向键

        //方向键
        Vector2 dPad = gamepad.dpad.ReadValue();
        //对应方向
        //gamepad.dpad.up 上
        //gamepad.dpad.down 下
        //gamepad.dpad.left 左
        //gamepad.dpad.right 右

        #endregion

        #region 手柄按钮

        //按钮
        //Y △
        //gamepad.buttonNorth
        //A X
        //gamepad.buttonSouth
        //B ○
        //gamepad.buttonWest
        //X □
        //gamepad.buttonEast

        #endregion

        #region 手柄肩键

        //前肩键
        //gamepad.leftShoulder 左肩键
        //gamepad.rightShoulder 右肩键

        //后扳机
        //gamepad.leftTrigger 左扳机
        //gamepad.rightTrigger 右扳机


        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
