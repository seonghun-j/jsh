using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Button _startButton;
    [SerializeField]
    private Transform _canvasTrans;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _startButton.onClick.AddListener(OnClickStartButton);

        DontDestroyOnLoad(gameObject);
    }

    private void OnClickStartButton()
    {
        _startButton.gameObject.SetActive(false);
        Debug.Log("OnClickStartButton");
        GameObject resGo= Resources.Load<GameObject>("PreFab/ModeUI");
        Debug.Log("resGo : " + resGo);

        GameObject sceneGo = Instantiate(resGo, _canvasTrans, false);
        MOdeUI uiComp = sceneGo.GetComponent<MOdeUI>();
        uiComp.AddTimeClickEvent(OnClickTimeAttackMode);
        uiComp.AddTimeClickEvent(OnClickStageMode);



    }

    private void OnClickTimeAttackMode()
    {
        Debug.Log("OnClickTimeAttackMode");
       
        StartCoroutine(LoadSceneAsync("GameScene"));
    }
    private IEnumerator LoadSceneAsync(string sceneName)
    { 
        
        yield return SceneManager.LoadSceneAsync(sceneName);
        GameObject resGo = Resources.Load<GameObject>("PreFab/ModeUI");
        Instantiate(resGo);
    }
    private void OnClickStageMode()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
