using FleetManagementSystem.Interfaces;

namespace FleetManagementSystem.Models;

//Task 8.2.1 – Implement IMaintainable
public class OfficeAsset : IMaintainable
{
    public string AssetName { get; set; }

    public OfficeAsset(string assetName)
    {
        AssetName = assetName;
    }

    // Task 8.2.2 – Implement IMaintainable in OfficeAsset
   public void PerformMaintenance() => Console.WriteLine($"Servicing office asset: {AssetName}");


  

}
