using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{// Start is called before the first frame update
    void Start()
    {
        //GetComponent<Rigidbody>().isKinematic = true;
        //���۰� ���ÿ� ��ü�� �߶����� �ʵ��� �ϱ� ���� �ڵ�

    }

    // Update is called once per frame
    void Update()
    {
        
        //if (Input.GetMouseButtonDown(0)) // ���콺 Ŭ���� �ߵ�
        //{
        //   GetComponent<Rigidbody>().isKinematic = false;
        //��ü�� ���� �������� �޵��� ����ϴ� �ڵ�
        //  Shoot();
        // �߻�!!
        //   }


    }
    public void Shoot(Vector3 speed)
    {   //Y������ 200��ŭ Z ������ 2000��ŭ�� ������ �߻��Ű�� �Լ�
        GetComponent<Rigidbody>().AddForce(speed);
    }
}
