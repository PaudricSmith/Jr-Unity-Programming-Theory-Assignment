using UnityEngine;



// INHERITANCE
public class Rifle : Gun
{



    private void Start()
    {
        fireRate = 1.5f;
        damage = 40;
        range = 100;
        accuracy = 0.75f;
    }



    // Unique method for Rifle
    public void AimedShot()
    {
        // Logic for a highly accurate, long-range shot
        // Example: Increase accuracy significantly for the next shot
    }

    // POLYMORPHISM
    public override void Fire()
    {
        // Implement the firing mechanism for the rifle
    }

    // POLYMORPHISM
    public override string GetDescription()
    {
        return $"Suitable for long-range engagements. Accuracy: {accuracy * 100}%.";
    }

    // POLYMORPHISM
    public override void Reload()
    {
        // Implement the reload mechanism for the rifle
    }
}