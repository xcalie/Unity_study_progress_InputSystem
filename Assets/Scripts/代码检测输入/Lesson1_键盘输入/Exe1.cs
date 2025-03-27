using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Exe1 : MonoBehaviour
{
    private GameObject obj;

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            RaycastHit info;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue()), out info))
            {
                obj = info.collider.gameObject;
            }
            else
            {
                obj = null;
            }
        }

        if (obj != null)
        {
            if (Keyboard.current.numpadPlusKey.wasPressedThisFrame ||
                Keyboard.current.equalsKey.wasPressedThisFrame)
            {
                obj.transform.localScale += new Vector3(1f, 1f, 1f);
            }

            if (Keyboard.current.numpadMinusKey.wasPressedThisFrame ||
                Keyboard.current.minusKey.wasPressedThisFrame)
            {
                obj.transform.localScale -= new Vector3(1f, 1f, 1f);
            }
        }

    }
}
