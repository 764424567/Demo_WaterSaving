using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    ModelControl m_ModelControl;
    // Use this for initialization
    void Start()
    {
        m_ModelControl = GameObject.Find("Scenes_Control").GetComponent<ModelControl>();
        m_ModelControl.m_ButtonOK.onClick.AddListener(delegate() { ButtonOnClick_ClosePanel(m_ModelControl.m_UiPanel); });
        m_ModelControl.m_ButtonOK2.onClick.AddListener(delegate () { ButtonOnClick_ClosePanel(m_ModelControl.m_UiPanel2); });
        m_ModelControl.m_ButtonImage.onClick.AddListener(delegate () { ButtonOnClick_ShowData(0); });
        m_ModelControl.m_ButtonImage2.onClick.AddListener(delegate () { ButtonOnClick_ShowData(1); });
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ButtonOnClick_ClosePanel(GameObject obj)
    {
        obj.SetActive(false);
    }

    public void ButtonOnClick_ShowData(int i)
    {
        m_ModelControl.m_UiPanel2.SetActive(true);
        switch (i)
        {
            case 0:
                m_ModelControl.m_TextTitle.text = "耕地整理节水技术：";
                m_ModelControl.m_TextContent.text = "平整土地，畅通排灌，修建池、塘、坑、窖、库、堤等拦水、蓄水设施是保证节水灌溉实施的基本条件，已得到农民的普遍认可。";
                break;
            case 1:
                m_ModelControl.m_TextTitle.text = "减免耕保水技术：";
                m_ModelControl.m_TextContent.text = "采用“以松代耕”、“以旋代耕”、“报留茬免耕套播”等方式，可以增加水分入渗深度和蓄水保墒能力，减少水分流失。";
                break;
            case 2:
                m_ModelControl.m_TextTitle.text = "节水灌溉技术：";
                m_ModelControl.m_TextContent.text = "目前生产上应用的主要有沟灌、沟中覆膜灌、低压管灌、滴灌、渗灌、喷灌、微灌等。如喷灌可节水50%，微灌可节水60%到70%，滴灌和渗灌可节水80%以上。";
                break;
            default:
                break;
        }
    }
}
