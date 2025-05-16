using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    // ������ ��� �������� � ����
    public GameObject appPrefab;
    // �������� �������� �����
    public float speed = 1f;
    // ����������, ����������� �������� ������
    public float leftAndRightEge = 10f;
    // ��������� ��������� ����������� ��������
    public float chanceToChangeDirections = 0.1f;
    // ������� �������� �����
    public float secondsBetweenAppleDrops = 1f;

    void Start()
    {
        
    }
        
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x > leftAndRightEge)
        {
            speed = -Mathf.Abs(speed); // ������ �������� �����
        }
        else if (pos.x < -leftAndRightEge)
        {
            speed = Mathf.Abs(speed); // ������ �������� ������
        }
    }
}
