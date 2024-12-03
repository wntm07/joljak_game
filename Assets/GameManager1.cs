using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{
    public GameObject gameoverText; // ���ӿ����� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ
    public Text timeText; // �����ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text recordText; // �ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ

    private float surviveTime; // �����ð�
    private bool isGameover; // ���ӿ��� ����

    void Start()
    {
        // �����ð��� ���ӿ��� ���� �ʱ�ȭ
        surviveTime = 0;
        isGameover = false;
    }


    void Update()
    {
        // ���ӿ����� �ƴ� ����
        if (!isGameover)
        {
            //�����ð� ����
            surviveTime += Time.deltaTime;
            //������ �����ð��� timeText ������Ʈ�� �̿��� ǥ��
            timeText.text = "Time : " + (int)surviveTime;
        }
        else
        {
            //���ӿ����� ���¿��� E Ű�� ���� ���
            if (Input.GetKeyDown(KeyCode.E))
            {
                //SampleScene ���� �ε�
                SceneManager.LoadScene("Dodge");
            }
        }
    }
    public void EndGame()
    {
        //���� ���¸� ���ӿ��� ���·� ��ȯ
        isGameover = true;
        //���ӿ��� �ؽ�Ʈ ���� ������Ʈ�� Ȱ��ȭ
        gameoverText.SetActive(true);

        //BestTime  Ű�� ����� ���������� �ְ� ��� ��������
        float bestTime = PlayerPrefs.GetFloat("BestTime");

        //���������� �ְ� ��Ϻ��� ���� ���� �ð��� �� ũ�ٸ�
        if (surviveTime > bestTime)
        {
            //�ְ��� ���� ���� ���� �ð� ������ ����
            bestTime = surviveTime;
            //����� �ְ����� BestTime Ű�� ����
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }
        //�ְ� ����� recordText �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
        recordText.text = "BestTime : " + (int)bestTime;
    }
}
