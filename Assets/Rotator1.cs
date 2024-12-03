using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator1 : MonoBehaviour
{
    public float rotationInterval = 30f; // ȸ�� ���� (�� ����)
    public float rotationAngle = 90f;    // �� ���� ȸ���� ����

    private float nextRotationTime;

    void Start()
    {
        // ���� ȸ�� �ð��� ���� �ð� + ȸ�� �������� ����
        nextRotationTime = Time.time + rotationInterval;
    }

    void Update()
    {
        // ���� �ð��� ���� ȸ�� �ð����� ũ�ų� ������ ȸ��
        if (Time.time >= nextRotationTime)
        {
            transform.Rotate(0f, rotationAngle, 0f);

            // ���� ȸ�� �ð��� ����
            nextRotationTime += rotationInterval;
        }
    }
}
