
using UnityEngine;

public class player : MonoBehaviour
{
    //註解

    //欄位語法
    //修飾詞 類型  名稱(指定值)
    //私人 private 不顯示(預設值)
    //公開 public 顯示

    //類型 四大類型
    //整數 int
    //浮點數 float
    //布林值 bool true 是、false 否
    //字串  string
    [Header("等級")]
    [Tooltip("這是腳色的等級")]
    public int lv = 1;
    [Header("移動速度"),Range(0, 300)]
    public float speed = 10.5f;
    public bool isDead = false;
    [Tooltip("這是角色的名稱")]
    public string cName = "貓咪";
    [Header("虛擬搖桿")]
    public FixedJoystick joystick; 

    //方法語法 Method - 處存複雜的城市區塊或演算法
    //修飾詞 類型 名稱 () {城市區塊或演算法 }
    // void 無類型
    private void Move()
    {

    }
    private void Attack()
    {

    }
    private void hit()
    {

    }
    private void Dead()
    {

    }

    //事件 特定時間會執行的方法
    //開始事件:播放後會執行一次
    private void Start()
    {
        //輸出(任何類型資料)
        print("恩~"); 
    }


    //更新事件:大約一秒執行60秒 60fps
    private void Update()
    {
        print("哈囉~");
    }








}