using UnityEngine;

public class script : MonoBehaviour
{
    #region [宣告]
    [Header("移動速度")]
    [Range(0f,50f)]
    public float Speed;
    [Header("跳躍高度")]
    [Range(0, 200)]
    public int Junp;
    [Header("講話內容")]
    public string Talk;
    [Header("是否取得雞蛋？")]
    public bool Egg = false;
    #endregion

    void Start()
    {
        print("遊戲開始!!!");
    }

    
    void Update()
    {
        Talk = "咕咕咕~~~";
        print(Talk);
    }
}
