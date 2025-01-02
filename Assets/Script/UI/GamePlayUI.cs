using Photon.Pun;
using UnityEngine;

public class GamePlayUI : MonoBehaviour
{
    public static GamePlayUI instance;

    [SerializeField] GameObject winning_Panel;
    [SerializeField] GameObject lose_Panel;


    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        winning_Panel.SetActive(false);
        lose_Panel.SetActive(false);
    }

    public void HomeBU()
    {
        PhotonNetwork.LoadLevel("Menu");
    }

    public void SetWinnLose(bool iswin,bool islose)
    {
        winning_Panel.SetActive(iswin);
        lose_Panel.SetActive(islose);

    }
}
