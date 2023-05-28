using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prehub_con: MonoBehaviour
{
    //�v���n�u
    public GameObject engel_con_top;//�ォ��o��I�����W��
    public GameObject devil_con_top;//�ォ��o��O���[����
    public GameObject engel_con_Diagonallyup_right;//�E�ォ��o��I�����W��
    public GameObject devil_con_Diagonallyup_right;//�E�ォ��o��O���[����
    public GameObject devil_con_Diagonallyup_left;//���ォ��o��O���[����
    public GameObject engel_con_Diagonallyup_left;//���ォ��o��I�����W��
    public GameObject engel_con_side_left;//������o��I�����W��
    public GameObject engel_con_side_right;//�E����o��I�����W��
    public GameObject devil_con_side_left;//������o��O���[����
    public GameObject devil_con_side_right;//�E����o��O���[����


    //�G�������ԊԊu
    private float interval;
    
    //�o�ߎ���
    private float time = 0f;
    //���̐�������p
    private bool swith = false;
    //�������̏ꏊ����p
    public int rand = 0;
    //���̐����J�E���g���p
    int soul_cnt;



    // Start is called before the first frame update
    void Start()
    {
        //���ԊԊu�����肷��
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
            //���Ԍv��
            time += Time.deltaTime;
            rand = Random.Range(1, 7);//1����6�̐��l���ł�
                                      //�o�ߎ��Ԃ��������ԂɂȂ����Ƃ�(�������Ԃ��傫���Ȃ����Ƃ�)
            if (time > interval && rand == 1)//�܂������I�����W����
            {
                if (soul_cnt %5==0&&interval>=0.6f)
                {
                    interval -= 0.2f;
                }
                //�C���X�^���X������(��������)
                GameObject en_con = Instantiate(engel_con_top);
                GameObject de_con = Instantiate(devil_con_top);
                //���W�����肷��
                en_con.transform.position = new Vector3(-4, 8, 0);
                de_con.transform.position = new Vector3(4, 8, 0);
                //�o�ߎ��Ԃ����������čēx���Ԍv�����n�߂�
                time = 0f;
                soul_cnt++;
            }
            if (time > interval && rand == 2)//�܂������I�����W���E
            {
                if (soul_cnt % 5 == 0 && interval >= 0.6f)
                {
                    interval -= 0.2f;
                }
                //�C���X�^���X������(��������)
                GameObject en_con = Instantiate(engel_con_top);
                GameObject de_con = Instantiate(devil_con_top);
                //���W�����肷��
                en_con.transform.position = new Vector3(4, 8, 0);
                de_con.transform.position = new Vector3(-4, 8, 0);
                //�o�ߎ��Ԃ����������čēx���Ԍv�����n�߂�
                time = 0f;
                soul_cnt++;
            }
            if (time > interval && rand == 3)//�΂߃I�����W����
            {
                if (soul_cnt % 5 == 0 && interval >= 0.6f)
                {
                    interval -= 0.2f;
                }
                //�C���X�^���X������(��������)
                GameObject en_con = Instantiate(engel_con_Diagonallyup_left);
                GameObject de_con = Instantiate(devil_con_Diagonallyup_right);
                //���W�����肷��
                en_con.transform.position = new Vector3(-12, 4, 0);
                de_con.transform.position = new Vector3(12, 4, 0);
                //�o�ߎ��Ԃ����������čēx���Ԍv�����n�߂�
                time = 0f;
                soul_cnt++;
            }
            if (time > interval && rand == 4)//�΂߃I�����W���E
            {
                if (soul_cnt % 5 == 0 && interval >= 0.6f)
                {
                    interval -= 0.2f;
                }
                //�C���X�^���X������(��������)
                GameObject en_con = Instantiate(engel_con_Diagonallyup_right);
                GameObject de_con = Instantiate(devil_con_Diagonallyup_left);
                //���W�����肷��
                en_con.transform.position = new Vector3(12, 4, 0);
                de_con.transform.position = new Vector3(-12, 4, 0);
                //�o�ߎ��Ԃ����������čēx���Ԍv�����n�߂�
                time = 0f;
                soul_cnt++;
            }
            if (time > interval && rand == 5)//���I�����W����
            {
                if (soul_cnt % 5 == 0 && interval >= 0.6f)
                {
                    interval -= 0.2f;
                }
                //�C���X�^���X������(��������)
                GameObject en_con = Instantiate(engel_con_side_left);
                GameObject de_con = Instantiate(devil_con_side_right);
                //���W�����肷��
                en_con.transform.position = new Vector3(-13, -5, 0);
                de_con.transform.position = new Vector3(13, -5, 0);
                //�o�ߎ��Ԃ����������čēx���Ԍv�����n�߂�
                time = 0f;
                soul_cnt++;
            }
            if (time > interval && rand == 6)//���I�����W���E
            {
                if (soul_cnt % 5 == 0 && interval >= 0.6f)
                {
                    interval -= 0.2f;
                }
                //�C���X�^���X������(��������)
                GameObject en_con = Instantiate(engel_con_side_right);
                GameObject de_con = Instantiate(devil_con_side_left);
                //���W�����肷��
                en_con.transform.position = new Vector3(13, -5, 0);
                de_con.transform.position = new Vector3(-13, -5, 0);
                //�o�ߎ��Ԃ����������čēx���Ԍv�����n�߂�
                time = 0f;
                soul_cnt++;
            }
            
        }
    }
}