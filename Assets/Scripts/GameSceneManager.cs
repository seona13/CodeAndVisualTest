using UnityEngine.SceneManagement;

public class GameSceneManager : MonoSingleton<GameSceneManager>
{
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }


    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


    public void ChangeScene(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }
}