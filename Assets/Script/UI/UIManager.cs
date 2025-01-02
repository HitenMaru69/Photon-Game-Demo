using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] GameObject connection_Panel;
    [SerializeField] GameObject createOrJoinRoom_Panel;
    

    private void Awake()
    {
        Instance = this; 
    }

    private void Start()
    {
        connection_Panel.SetActive(true);
        createOrJoinRoom_Panel.SetActive(false);
    }

    public void HideConnectionPanel()
    {
        connection_Panel.SetActive(false);
        createOrJoinRoom_Panel.SetActive(true);
    }


}
