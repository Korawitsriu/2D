using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneName;
   
    public void changeScene()
    {
        SceneManager.LoadScene(sceneName);
    }

}
