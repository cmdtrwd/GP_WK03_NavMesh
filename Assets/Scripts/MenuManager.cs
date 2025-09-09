using UnityEngine;
using Unity.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void CloseMenu()
    {
        anim.SetTrigger("CloseMenu");
        Invoke("LoadGameScene", 2f);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
