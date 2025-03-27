using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }





    #region 当形式为Send Messages时，Unity会自动调用这些函数
    public void OnDeviceLost()
    {
        Debug.Log("Device Lost");
    }

    public void OnDeviceRegained()
    {
        Debug.Log("Device Regained");
    }

    public void OnControlsChanged()
    {
        Debug.Log("Controls Changed");
    }

    #endregion


}
