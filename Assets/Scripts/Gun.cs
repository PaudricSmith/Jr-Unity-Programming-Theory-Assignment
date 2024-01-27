using UnityEngine;



public abstract class Gun : MonoBehaviour, UIMainScene.IUIInfoContent
{

    [SerializeField] private string gunName;
    [SerializeField] private string ammoType;

    [SerializeField] protected float range;
    [SerializeField] protected float fireRate;
    [SerializeField] protected float accuracy;
    [SerializeField] protected int damage;

    public string GunName => gunName;
    public string AmmoType => ammoType;


    public virtual string GetGunName() => GunName;
    public virtual string GetAmmoType() => AmmoType;
    public virtual int CalculateDamage => damage;


    public abstract string GetDescription();
    public abstract void Fire();
    public abstract void Reload();
}
