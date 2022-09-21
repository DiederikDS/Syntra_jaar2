using Oefening_House.Classes;
using Oefening_House.Enums;
using System.Linq;

List<House> Houses = new List<House>()
{
    new House() {Name ="Sea Breeze", BedroomCount = 2, Price = 350000, Region = "Coast", Squaremeter = 150, Type = EnumType.Bungalow},
    new House() {Name ="Shack", BedroomCount = 1, Price = 120000, Region = "Woodland", Squaremeter = 75, Type = EnumType.Cottage},
    new House() {Name ="Birch", BedroomCount = 6, Price = 1200000, Region = "Woodland", Squaremeter = 780, Type = EnumType.Villa},
    new House() {Name ="Sea Breeze", BedroomCount = 4, Price = 500000, Region = "Coast", Squaremeter = 270, Type = EnumType.Villa},
    new House() {Name ="Honest Work", BedroomCount = 3, Price = 450000, Region = "Farmland", Squaremeter = 500, Type = EnumType.Farm},
    new House() {Name ="Concrete Sea", BedroomCount = 3, Price = 400000, Region = "City", Squaremeter = 200, Type = EnumType.Cottage},
    new House() {Name ="Appartement 16A", BedroomCount = 2, Price = 220000, Region = "City", Squaremeter = 150, Type = EnumType.Bungalow},
    new House() {Name ="Sewer Tunnel 23x6", BedroomCount = 1, Price = 0, Region = "City", Squaremeter = 25, Type = EnumType.Cottage},
    new House() {Name ="Always Fresh", BedroomCount = 6, Price = 1500000, Region = "Farmland", Squaremeter = 1000, Type = EnumType.Farm},
    new House() {Name ="Appartement 2.6", BedroomCount = 2, Price = 425000, Region = "Coast", Squaremeter = 210, Type = EnumType.Bungalow},
    new House() {Name ="Royal Palace", BedroomCount = 8, Price = 3500000, Region = "City", Squaremeter = 750, Type = EnumType.Villa}
};

//-------------------------------------------------------------------------------------------------------------------------------------------------------

//var HousesGrouped1 = from House in Houses
//                   group House by House.Region into housesGrouped
//                   select housesGrouped.Key + ": " + housesGrouped.Count();

var HousesGrouped1 = Houses.GroupBy(house => house.Region)
                            .Select(houseGroup => houseGroup.Key + ": " + houseGroup.Count());

foreach (var item in HousesGrouped1)
{
    Console.WriteLine(item + "\n");
}

Console.WriteLine("--------------------------------------------------------------------------------------------");
//-------------------------------------------------------------------------------------------------------------------------------------------------------

//var HousesFiltered = from House in Houses
//                     select House.Name + ": " + House.BedroomCount;

var HousesFiltered = Houses.Select(house => house.Name + ": " + house.BedroomCount);

foreach (var item in HousesFiltered)
{
    Console.WriteLine(item + "\n");
}

Console.WriteLine("--------------------------------------------------------------------------------------------");
//-------------------------------------------------------------------------------------------------------------------------------------------------------

//var HousesGrouped2 = from house in Houses
//                     group house by house.Type into housesGrouped
//                     select housesGrouped.Key + ": " + housesGrouped.Count();

var HousesGrouped2 = Houses.GroupBy(house => house.Type)
                            .Select(housesGrouped => housesGrouped.Key + ": " + housesGrouped.Count());

foreach (var item in HousesGrouped2)
{
    Console.WriteLine(item + "\n");
}

Console.WriteLine("--------------------------------------------------------------------------------------------");
//-------------------------------------------------------------------------------------------------------------------------------------------------------

//var HousesFiltered2 = from house in Houses
//                      where house.Squaremeter >= 100
//                      select house.Name;

var HousesFiltered2 = Houses.Where(house => house.Squaremeter >= 100)
                            .Select(House => House.Name);
                            

foreach (var item in HousesFiltered2)
{
    Console.WriteLine(item + "\n");
}

Console.WriteLine("--------------------------------------------------------------------------------------------");
//-------------------------------------------------------------------------------------------------------------------------------------------------------

var HousesGrouped3 = from house in Houses
                     where Houses.Aggregate(decimal, house.Price) > 50000
                     select