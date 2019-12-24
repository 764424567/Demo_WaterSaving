using UnityEngine;
using UnityEngine.UI;

public class ModelControl : MonoBehaviour
{
    //设置从哪个摄像机发射射线
    public Camera m_Camera;
    //控制UI
    public GameObject m_UiPanel;
    public GameObject m_UiPanel2;
    //ok button
    public Button m_ButtonOK;
    public Button m_ButtonOK2;
    public Button m_ButtonImage;
    public Button m_ButtonImage2;
    //text
    public Text m_TextTitle;
    public Text m_TextContent;

    void Awake()
    {
        m_UiPanel.SetActive(false);
        m_UiPanel2.SetActive(false);
    }
}
