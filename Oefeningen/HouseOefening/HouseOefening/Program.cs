using HouseOefening.Classes;

var houses = new List<House>();
houses.Add(new House() { BedroomCount = 1, Name = "Small house", Price = 95000, Region = "West-Vlaanderen", Squaremeter = 70, Type = HouseType.Bungalow });
houses.Add(new House() { BedroomCount = 3, Name = "Small villa", Price = 385000, Region = "Oost-Vlaanderen", Squaremeter = 170, Type = HouseType.Villa });
houses.Add(new House() { BedroomCount = 2, Name = "Small cottage", Price = 375000, Region = "West-Vlaanderen", Squaremeter = 120, Type = HouseType.Cottage });
houses.Add(new House() { BedroomCount = 4, Name = "Big villa", Price = 555000, Region = "Brussel", Squaremeter = 230, Type = HouseType.Villa });
houses.Add(new House() { BedroomCount = 3, Name = "Cool farm", Price = 425000, Region = "West-Vlaanderen", Squaremeter = 250, Type = HouseType.Farm });

var result1 = from house in houses
              group house by house.Region into regionGroup
              select regionGroup.Key + ": " + regionGroup.Count();

//ShowResult(result1);

var result2 = houses.GroupBy(e => e.Region).Select(e => e.Key + ": " + e.Count());

//ShowResult(result2);

var result3 = houses.Select(e => $"{e.Name} : {e.BedroomCount}");

//ShowResult(result3);

var result4 = houses.GroupBy(e => e.Type).Select(e => $"{e.Key} : {e.Count()}");

//ShowResult(result4);

var result5 = houses.Where(e => e.Squaremeter >= 100).Select(e => $"{e.Name}");

//ShowResult(result5);

var result6 = houses.GroupBy(e => Math.Floor(e.Price / 50000)).Select(e => $"{e.Key * 50000} - {(e.Key + 1) * 50000} : {e.Count()} ");

//ShowResult(result6);




void ShowResult(IEnumerable<string> houses)
{
    foreach(var house in houses)
    {
        Console.WriteLine(house);
    }
    Console.WriteLine("");
}