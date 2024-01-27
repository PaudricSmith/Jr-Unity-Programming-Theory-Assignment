using UnityEngine;



public class UserController : MonoBehaviour
{

    [SerializeField] private Camera gameCamera;
    [SerializeField] private AudioSource selectAudioSource;
    [SerializeField] private AudioClip selectAudioClip;



    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left click to select
        {
            HandleSelection();
        }
    }


    private void HandleSelection()
    {
        RaycastHit hit;
        Ray ray = gameCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Gun gun = hit.collider.GetComponent<Gun>();
            if (gun != null)
            {
                UIMainScene.Instance.ActivatePopupWindow();
                UIMainScene.Instance.SetNewInfoContent(gun);

                selectAudioSource.PlayOneShot(selectAudioClip);
            }
            else
            {
                // No Gun script found, or it's something else so deactivate popup window
                UIMainScene.Instance.DeactivatePopupWindow();
            }
        }
        else
        {
            // Raycast didn't hit any collider so deactivate popup window
            UIMainScene.Instance.DeactivatePopupWindow();
        }
    }
}
