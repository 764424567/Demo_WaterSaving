using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private Vector3 offest;
    private Vector3 oldPos;
    private Vector3 newPos;
    void Update()
    {
        newPos = Input.mousePosition;
        //鼠标滚轮控制
        float wheel = Input.GetAxis("Mouse ScrollWheel");
        if (wheel < 0 && this.transform.position.y < 150)
        {
            Vector3 vec = this.transform.TransformVector(0, 0, -1);
            transform.position += vec * 1;
        }
        else if (wheel > 0 && this.transform.position.y > 3)
        {
            Vector3 vec = this.transform.TransformVector(0, 0, 1);
            transform.position += vec * 1;
        }
        //鼠标中键控制
        if (Input.GetMouseButton(2))
        {
            offest = newPos - oldPos;
            if (Mathf.Abs(offest.x) > 0 && Mathf.Abs(offest.x) >= Mathf.Abs(offest.y) && oldPos != newPos)
            {
                if (offest.x < 0)//向右
                {
                    Vector3 vec = this.transform.TransformVector(1, 0, 0);
                    transform.position += vec * 0.5f;

                }
                else//向左
                {
                    Vector3 vec = this.transform.TransformVector(-1, 0, 0);
                    transform.position += vec * 0.5f;

                }
            }
            if (Mathf.Abs(offest.y) > 0 && Mathf.Abs(offest.x) < Mathf.Abs(offest.y) && oldPos != newPos)
            {
                if (offest.y > 0)//向后
                {
                    Vector3 vec = this.transform.TransformVector(0, 0, -1);
                    vec.y = 0;
                    vec.Normalize();
                    transform.position += vec * 0.5f;

                }
                else//向前
                {
                    Vector3 vec = this.transform.TransformVector(0, 0, 1);
                    vec.y = 0;
                    vec.Normalize();
                    transform.position += vec * 0.5f;
                }
            }
        }
        //W、S、A、D控制移动
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 vec = this.transform.TransformVector(-1, 0, 0);
            transform.position += vec * 0.3f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 vec = this.transform.TransformVector(1, 0, 0);
            transform.position += vec * 0.3f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 vec = this.transform.TransformVector(0, 0, 1);
            vec.y = 0;
            vec.Normalize();
            transform.position += vec * 0.3f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 vec = this.transform.TransformVector(0, 0, -1);
            vec.y = 0;
            vec.Normalize();
            transform.position += vec * 0.3f;
        }

        //鼠标右键控制旋转
        if (Input.GetMouseButton(1))
        {
            float dx = Input.GetAxis("Mouse X");
            float dy = Input.GetAxis("Mouse Y");
            transform.localEulerAngles += new Vector3(-dy * 4, dx * 4, 0);
        }
        oldPos = newPos;
    }
}


