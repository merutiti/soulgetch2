using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prehub_con: MonoBehaviour
{
    //プレハブ
    public GameObject engel_con_top;//上から出るオレンジ魂
    public GameObject devil_con_top;//上から出るグリーン魂
    public GameObject engel_con_Diagonallyup_right;//右上から出るオレンジ魂
    public GameObject devil_con_Diagonallyup_right;//右上から出るグリーン魂
    public GameObject devil_con_Diagonallyup_left;//左上から出るグリーン魂
    public GameObject engel_con_Diagonallyup_left;//左上から出るオレンジ魂
    public GameObject engel_con_side_left;//左から出るオレンジ魂
    public GameObject engel_con_side_right;//右から出るオレンジ魂
    public GameObject devil_con_side_left;//左から出るグリーン魂
    public GameObject devil_con_side_right;//右から出るグリーン魂


    //敵生成時間間隔
    private float interval;
    
    //経過時間
    private float time = 0f;
    //魂の生成制御用
    private bool swith = false;
    //魂生成の場所制御用
    public int rand = 0;
    //魂の生成カウント数用
    int soul_cnt;



    // Start is called before the first frame update
    void Start()
    {
        //時間間隔を決定する
        interval = 3.0f;
        soul_cnt = 0;
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            swith = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

      
        if (swith == true)
        {
            //時間計測
            time += Time.deltaTime;
            rand = Random.Range(1, 7);//1から6の数値がでる
                                      //経過時間が生成時間になったとき(生成時間より大きくなったとき)
            if (time > interval && rand == 1)//まっすぐオレンジが左
            {
                if (soul_cnt %5==0&&interval>=0.6f)
                {
                    interval -= 0.2f;
                }
                //インスタンス化する(生成する)
                GameObject en_con = Instantiate(engel_con_top);
                GameObject de_con = Instantiate(devil_con_top);
                //座標を決定する
                en_con.transform.position = new Vector3(-4, 8, 0);
                de_con.transform.position = new Vector3(4, 8, 0);
                //経過時間を初期化して再度時間計測を始める
                time = 0f;
                soul_cnt++;
            }
            if (time > interval && rand == 2)//まっすぐオレンジが右
            {
                if (soul_cnt % 5 == 0 && interval >= 0.6f)
                {
                    interval -= 0.2f;
                }
                //インスタンス化する(生成する)
                GameObject en_con = Instantiate(engel_con_top);
                GameObject de_con = Instantiate(devil_con_top);
                //座標を決定する
                en_con.transform.position = new Vector3(4, 8, 0);
                de_con.transform.position = new Vector3(-4, 8, 0);
                //経過時間を初期化して再度時間計測を始める
                time = 0f;
                soul_cnt++;
            }
            if (time > interval && rand == 3)//斜めオレンジが左
            {
                if (soul_cnt % 5 == 0 && interval >= 0.6f)
                {
                    interval -= 0.2f;
                }
                //インスタンス化する(生成する)
                GameObject en_con = Instantiate(engel_con_Diagonallyup_left);
                GameObject de_con = Instantiate(devil_con_Diagonallyup_right);
                //座標を決定する
                en_con.transform.position = new Vector3(-12, 4, 0);
                de_con.transform.position = new Vector3(12, 4, 0);
                //経過時間を初期化して再度時間計測を始める
                time = 0f;
                soul_cnt++;
            }
            if (time > interval && rand == 4)//斜めオレンジが右
            {
                if (soul_cnt % 5 == 0 && interval >= 0.6f)
                {
                    interval -= 0.2f;
                }
                //インスタンス化する(生成する)
                GameObject en_con = Instantiate(engel_con_Diagonallyup_right);
                GameObject de_con = Instantiate(devil_con_Diagonallyup_left);
                //座標を決定する
                en_con.transform.position = new Vector3(12, 4, 0);
                de_con.transform.position = new Vector3(-12, 4, 0);
                //経過時間を初期化して再度時間計測を始める
                time = 0f;
                soul_cnt++;
            }
            if (time > interval && rand == 5)//横オレンジが左
            {
                if (soul_cnt % 5 == 0 && interval >= 0.6f)
                {
                    interval -= 0.2f;
                }
                //インスタンス化する(生成する)
                GameObject en_con = Instantiate(engel_con_side_left);
                GameObject de_con = Instantiate(devil_con_side_right);
                //座標を決定する
                en_con.transform.position = new Vector3(-13, -5, 0);
                de_con.transform.position = new Vector3(13, -5, 0);
                //経過時間を初期化して再度時間計測を始める
                time = 0f;
                soul_cnt++;
            }
            if (time > interval && rand == 6)//横オレンジが右
            {
                if (soul_cnt % 5 == 0 && interval >= 0.6f)
                {
                    interval -= 0.2f;
                }
                //インスタンス化する(生成する)
                GameObject en_con = Instantiate(engel_con_side_right);
                GameObject de_con = Instantiate(devil_con_side_left);
                //座標を決定する
                en_con.transform.position = new Vector3(13, -5, 0);
                de_con.transform.position = new Vector3(-13, -5, 0);
                //経過時間を初期化して再度時間計測を始める
                time = 0f;
                soul_cnt++;
            }
            
        }
    }
}