using UnityEngine;
using Unity.UI;

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
    }
}
