using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIPanel : MonoBehaviour
{
    public Button btn;

    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(() =>
        {
            Player.Instance.transform.position = new Vector3(Main.Instance.birthPoint.x, Main.Instance.birthPoint.y,
                Main.Instance.birthPoint.z);
        });
    }

    // Update is called once per frame
    void Update()
    {
    }
}