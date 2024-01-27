using UnityEngine;



// INHERITANCE
public class Shotgun : Gun
{

    [SerializeField] private int pelletCount;



    private void Start()
    {
        fireRate = 1.0f;
        accuracy = 0.5f;
        damage = 30; 
        range = 20;   
        pelletCount = 8; // Number of pellets per shot
    }



    // Unique method for Shotgun
    public void Blast()
    {
        // Logic for a powerful close-range blast
        // Example: Deal extra damage or affect a wider area for the next shot
    }

    // POLYMORPHISM
    public override void Fire()
    {
        // Implement the firing mechanism for the shotgun
    }

    // POLYMORPHISM
    public override string GetDescription()
    {
        return $"Effective in short-range with a wide spread. Pellets per shot: {pelletCount}. Accuracy: {accuracy * 100}%.";
    }

    // POLYMORPHISM
    public override void Reload()
    {
        // Implement the reload mechanism for the shotgun
    }
}