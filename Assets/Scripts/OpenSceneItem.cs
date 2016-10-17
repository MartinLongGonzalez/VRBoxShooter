using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;
using UnityEngine.SceneManagement;

public class OpenSceneItem : MonoBehaviour {

    [SerializeField]
    private string m_SceneToLoad;
    [SerializeField]
    private VRInteractiveItem m_InteractiveItem;


    private void OnEnable()
    {
        m_InteractiveItem.OnClick += HandleClick;
    }


    private void OnDisable()
    {
        m_InteractiveItem.OnClick -= HandleClick;
    }

    //Handle the Click event
    private void HandleClick()
    {
        SceneManager.LoadScene(m_SceneToLoad, LoadSceneMode.Single);
    }
}
