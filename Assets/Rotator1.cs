using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator1 : MonoBehaviour
{
    public float rotationInterval = 30f; // 회전 간격 (초 단위)
    public float rotationAngle = 90f;    // 한 번에 회전할 각도

    private float nextRotationTime;

    void Start()
    {
        // 다음 회전 시간이 현재 시간 + 회전 간격으로 설정
        nextRotationTime = Time.time + rotationInterval;
    }

    void Update()
    {
        // 현재 시간이 다음 회전 시간보다 크거나 같으면 회전
        if (Time.time >= nextRotationTime)
        {
            transform.Rotate(0f, rotationAngle, 0f);

            // 다음 회전 시간을 갱신
            nextRotationTime += rotationInterval;
        }
    }
}
