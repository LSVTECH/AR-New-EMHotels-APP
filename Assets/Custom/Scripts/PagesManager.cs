using UnityEngine;

public class PagesManager : MonoBehaviour
{
    public GameObject pageToShow;
    public GameObject pageToHide;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangePage()
    {
        if (pageToShow) {
            pageToShow.SetActive(true);
        }
        if (pageToHide)
        {
            pageToHide.SetActive(false);
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
