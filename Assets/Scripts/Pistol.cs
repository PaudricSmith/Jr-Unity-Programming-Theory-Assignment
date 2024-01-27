using UnityEngine;



// INHERITANCE
public class Pistol : Gun
{



    private void Start()
    {
        fireRate = 0.5f;
        accuracy = 0.9f;
        damage = 20;
        range = 50;
    }


    // Unique method for Pistol
    public void QuickDraw()
    {
        // Logic to quickly draw the pistol, perhaps increasing fire rate temporarily
        // Example: Increase fire rate for a short duration
    }


    // POLYMORPHISM
    public override void Fire()
    {
        // Implement the firing mechanism for the pistol
    }

    // POLYMORPHISM
    public override string GetDescription()
    {
        return $"Ideal for close-range combat. Accuracy: {accuracy * 100}%.";
    }

    // POLYMORPHISM
    public override void Reload()
    {
        // Implement the reload mechanism for the pistol
    }
}