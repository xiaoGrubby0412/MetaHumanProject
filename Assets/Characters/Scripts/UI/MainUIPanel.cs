using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIPanel : MonoBehaviour
{
    public Button btn;

    public Button btnSwitchToRun;

    public Button btnSwitchToWalk;
    
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(() =>
        {
            Player.Instance.transform.position = new Vector3(Main.Instance.birthPoint.x, Main.Instance.birthPoint.y,
                Main.Instance.birthPoint.z);
        });
        
        btnSwitchToRun.onClick.AddListener(() =>
        {
            PlayerJoystickController.instance.SetMoveState(false);
            SetSwitchBtnState();
        });
        
        btnSwitchToWalk.onClick.AddListener(() =>
        {
            PlayerJoystickController.instance.SetMoveState(true);
            SetSwitchBtnState();
        });
        
        SetSwitchBtnState();
    }

    private void SetSwitchBtnState()
    {
        bool ifWalk = PlayerJoystickController.instance.ifWalk;
        btnSwitchToRun.gameObject.SetActive(ifWalk);
        btnSwitchToWalk.gameObject.SetActive(!ifWalk);
    }

    // Update is called once per frame
    void Update()
    {
    }
}