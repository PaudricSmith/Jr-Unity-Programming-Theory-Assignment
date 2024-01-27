using UnityEngine;
using UnityEngine.UI;



public class InfoPopup : MonoBehaviour
{

    [SerializeField] private Text gunName;
    [SerializeField] private Text ammoType;
    [SerializeField] private Text description;



    public Text GunName { get => gunName; set => gunName = value; }
    public Text AmmoType { get => ammoType; set => ammoType = value; }
    public Text Description { get => description; set => description = value; }
}
