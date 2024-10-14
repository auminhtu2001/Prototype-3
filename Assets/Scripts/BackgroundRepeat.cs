using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeat : MonoBehaviour
{
    private Vector3 startPos; //khởi tạo biến struct Vector3 tên là startPos -> vị trí bắt đầu của vật thể
    private float repeatWidth; //khởi tạo biến float repeatWidth -> độ dài của vật thể

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position; //bắt đầu hàm Start -> gán biến startPos với vị trí hiện tại của vật thể (x,y,z)
        repeatWidth = GetComponent<BoxCollider>().size.x / 2; //gán biến repeatWidth tương đương với giá trị tọa độ trục x của Component Box Collider
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < startPos.x - repeatWidth) //đặt điều kiện, nếu tọa độ x của vật thể bé hơn tọa độ x của biến start pos với giá trị là -50 đơn vị
        {
            transform.position = startPos; //thực hiện việc trả lại vị trí của vật thể về với vị trí bắt đầu
        }
    }
}
