using UnityEngine;

public class RayControl : MonoBehaviour
{
    ModelControl m_ModelControl;

    void Start()
    {
        m_ModelControl = GameObject.Find("Scenes_Control").GetComponent<ModelControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = m_ModelControl.m_Camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.DrawLine(ray.origin, hit.point);
                GameObject gameobj = hit.collider.gameObject;
                if (gameobj.tag == "collider")
                {
                    m_ModelControl.m_UiPanel.transform.position = m_ModelControl.m_UiPanel.transform.position = new Vector3(Input.mousePosition.x + 150, Input.mousePosition.y, Input.mousePosition.z);
                    m_ModelControl.m_UiPanel.SetActive(true);
                }
            }
        }
    }
}
