using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class loginview : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject loginNode;
    public GameObject otherNode;
    public GameObject creditNode;
    public GameObject helpNode;
    public Button starBtn;
    public Button otherBtn;
    public Button creditBtn;
    public Button helpBtn;
    void Start()
    {
        starBtn.onClick.AddListener(startCall);
        otherBtn.onClick.AddListener(otherCall);
        creditBtn.onClick.AddListener(creditCall);
        helpBtn.onClick.AddListener(helpCall);
    }

    void startCall() {
        AudioManager1.Instance.playBtnMusic();
        SceneManager.LoadScene(1);
    }

    void otherCall()
    {
        AudioManager1.Instance.playBtnMusic();
        otherNode.SetActive(true);
    }

    void creditCall()
    {
        AudioManager1.Instance.playBtnMusic();
        creditNode.SetActive(true);
    }

    void helpCall()
    {
        AudioManager1.Instance.playBtnMusic();
        helpNode.SetActive(true);
    }

    public void StartScene(int index) {
        AudioManager1.Instance.playBtnMusic();
        SceneManager.LoadScene(index);
    }

    public void hideCall()
    {
        AudioManager1.Instance.playBtnMusic();
        otherNode.SetActive(true);
    }

    public void hidecreditCall()
    {
        AudioManager1.Instance.playBtnMusic();
        creditNode.SetActive(false);
    }

    public void hidehelpCall()
    {
        AudioManager1.Instance.playBtnMusic();
        helpNode.SetActive(false);
    }

    public void returnLogin()
    {
        AudioManager1.Instance.playBtnMusic();
        otherNode.SetActive(false);
        loginNode.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
