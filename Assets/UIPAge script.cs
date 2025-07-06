using UnityEngine;
using UnityEngine.SceneManagement;


public class newScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void Load()
    {
        SceneManager.LoadSceneAsync(1);
    }

    // Update is called once per frame
    public void quit()
    {
        Application.Quit();
    }
}