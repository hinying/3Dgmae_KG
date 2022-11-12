using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollower : MonoBehaviour
{
    [Header("遊戲物件")]
    public GameObject player;
    [Header("攝影機偏移量")]
    public Vector3 offset = new Vector3(20, 4, 0); //宣告一個offset新座標

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //把此程式的位置參照player遊戲物件的位置
        transform.position = player.transform.position + new Vector3 (0 , 8 , -10);
    }
}
