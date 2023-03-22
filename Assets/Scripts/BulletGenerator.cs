using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject BulletPrefeb;
    public GameObject player;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {   
            GameObject bullet = Instantiate(BulletPrefeb) as GameObject;
            bullet.transform.position = player.transform.position;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // ray class
            Vector3 shooting = ray.direction; // ���� ���ϱ�
            shooting = shooting.normalized * 2000; // �߻��ϴ� �� ����
            bullet.GetComponent<BulletController>().Shoot(shooting);
        }
    }
}
