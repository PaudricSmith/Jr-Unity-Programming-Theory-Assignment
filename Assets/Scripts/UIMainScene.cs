using UnityEngine;
using UnityEngine.SceneManagement;



public class UIMainScene : MonoBehaviour
{

    public static UIMainScene Instance { get; private set; }
    public InfoPopup InfoPopup;


    public interface IUIInfoContent
    {
        string GetGunName();
        string GetAmmoType();
        string GetDescription();
    }



    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        InfoPopup.gameObject.SetActive(false);
    }


    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }


    public void SetNewInfoContent(IUIInfoContent content)
    {
        if (content == null)
        {
            InfoPopup.gameObject.SetActive(false);
        }
        else
        {
            InfoPopup.gameObject.SetActive(true);

            InfoPopup.GunName.text = content.GetGunName();
            InfoPopup.AmmoType.text = content.GetAmmoType();
            InfoPopup.Description.text = content.GetDescription();
        }
    }


    public void ActivatePopupWindow() => InfoPopup.gameObject.SetActive(true);
    public void DeactivatePopupWindow() => InfoPopup.gameObject.SetActive(false);


    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
