using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {
	//player speed
	public float m_speed = 10f;
    public Animator animator;
    bool isMoveing = false;
    private int coinCount = 0;
    public GameObject winView;
    public Text coinText;
    public int guanqia=0;
    private float effectTime = 0.2f;
    void Update () {
        isMoveing = false;
        if (Input.GetKey(KeyCode.W) ) //前
        {
            this.transform.Translate(Vector3.forward * m_speed * Time.deltaTime);
            isMoveing = true;
        }
        if (Input.GetKey(KeyCode.S)) //后
        {
            this.transform.Translate(Vector3.forward * -m_speed * Time.deltaTime);
            isMoveing = true;
        }
        if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow)) //左
        {
            transform.Rotate(new Vector3(0, -Time.deltaTime * 50, 0), Space.Self);
            isMoveing = true;
        }
        if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow)) //右
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * 50, 0), Space.Self);
            isMoveing = true;
        }
        if (Input.GetKey(KeyCode.UpArrow)) //上
        {
            this.transform.Translate(Vector3.up * m_speed * Time.deltaTime);
            isMoveing = true;
        }
        if (Input.GetKey(KeyCode.DownArrow)) //下
        {
            this.transform.Translate(Vector3.up * -m_speed * Time.deltaTime);
            isMoveing = true;
        }

        if (animator == null) {
            if (isMoveing == true) {
                if (effectTime > 0.4f)
                {
                    if (guanqia == 1)
                    {
                        AudioManager_1.Instance.playWalkEffect();
                    }
                    else if (guanqia == 2)
                    {
                        AudioManager_2.Instance.playWalkEffect();
                    }
                    else if (guanqia == 3)
                    {
                        AudioManager_3.Instance.playWalkEffect();
                    }
                    effectTime = 0;
                }
                else
                {
                    effectTime = effectTime + Time.deltaTime;
                }
            }

            return;
        }
        
        if (isMoveing == true)
        {
            animator.SetBool("run", true);
        }
        else {
            animator.SetBool("run", false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin") {
            GameObject.Destroy(collision.gameObject);
            coinCount++;
            UpdateView();
            if (guanqia == 1)
            {
                AudioManager_1.Instance.playCollectBtnEffect();
            }
            else if (guanqia == 2)
            {
                AudioManager_2.Instance.playCollectBtnEffect();
            }
            else if (guanqia == 3)
            {
                AudioManager_3.Instance.playCollectBtnEffect();
            }
        }
    }

    public void UpdateView() {
        coinText.text = coinCount.ToString() + "/5";
        if (coinCount >= 5) {
            winView.SetActive(true);
        }
        if (coinCount == 5) {
            if (guanqia == 1)
            {
                AudioManager_1.Instance.playWinEffect();
            }
            else if (guanqia == 2)
            {
                AudioManager_2.Instance.playWinEffect();
            }
            else if (guanqia == 3)
            {
                AudioManager_3.Instance.playWinEffect();
            }
        }
    }

    public void NextScene() {
        if (guanqia == 1)
        {
            AudioManager_1.Instance.playNextBtnEffect();
        }
        else if (guanqia == 2)
        {
            AudioManager_2.Instance.playNextBtnEffect();
        }
        else if (guanqia == 3)
        {
            AudioManager_3.Instance.playNextBtnEffect();
        }

        if (guanqia == 3)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(guanqia + 1);
        }
    }
    public void lastScene()
    {
        if (guanqia == 1)
        {
            AudioManager_1.Instance.playLatBtnEffect();
        }
        else if (guanqia == 2)
        {
            AudioManager_2.Instance.playLatBtnEffect();
        }
        else if (guanqia == 3)
        {
            AudioManager_3.Instance.playLatBtnEffect();
        }

        SceneManager.LoadScene(guanqia - 1);
    }
}
