List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};

// var stratovolcanoEruptions = eruptions.Where(eruption => eruption.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!


// FIRST CHILE ERUPTION
// var chileEruption = eruptions.First(x => x.Location == "Chile");
// System.Console.WriteLine(chileEruption);

// FIRST HAWAII ERUPTION  **************************************  in writeline: if hawaii eruption is null, print the string after the ?? **************************************
// var hawaiiEruption = eruptions.FirstOrDefault(x => x.Location == "Hawaiian Is");
// System.Console.WriteLine(hawaiiEruption?.ToString() ?? "No Hawaiian Is Eruption Found");

// FIRST GREENLAND ERUPTION
// var greenlandEruption = eruptions.FirstOrDefault(x => x.Location == "Greenland");
// System.Console.WriteLine(greenlandEruption?.ToString() ?? "No Greenland Eruption Found");

// FIRST NEW ZEALAND AFTER 1900
// var newzealandEruption = eruptions.FirstOrDefault(x => x.Location == "New Zealand" && x.Year > 1900);
// System.Console.WriteLine(newzealandEruption?.ToString() ?? "No New Zealand Eruption Found");

// TALLCANOS
// var tallcanoEruptions = eruptions.Where(x => x.ElevationInMeters > 2000);
// PrintEach(tallcanoEruptions, "Volcanos over 2000m tall.");

// EL-RUPTIONS
// var elEruptions = eruptions.Where(x => x.Volcano[0] == 'L');
// PrintEach(elEruptions, "Volcanos over 2000m tall.");
// System.Console.WriteLine(elEruptions.Count());

// HIGHEST ELEVATION and PRINT THE NAME AFTERWARDS
// var highEruptions = eruptions.Max(x => x.ElevationInMeters);
// System.Console.WriteLine(highEruptions);
// var highnameEruption = eruptions.First(x => x.ElevationInMeters == highEruptions);
// System.Console.WriteLine(highnameEruption.Volcano);

// ALPHACANO
// var alphaEruptions = eruptions.Select(x => x.Volcano).Order();
// alphaEruptions.ToList().ForEach(System.Console.WriteLine);

// SUMCANO
// var sumEruptions = eruptions.Sum(x => x.ElevationInMeters);
// System.Console.WriteLine(sumEruptions);

// 2000m-CANO
// var ytwokEruptions = eruptions.Any(x => x.Year == 2000);

// STRATO-THREE-CANO
// var stratthreeEruptions = eruptions.Where(x => x.Type == "Stratovolcano").Take(3);
// PrintEach(stratthreeEruptions);

// YEAR 1000 AD ALPHABETICAL
// var onekalphaEruptions = eruptions.Where(x => x.Year < 1000).OrderBy(x => x.Volcano);
// PrintEach(onekalphaEruptions);

// SAME BUT DIFFERENT
// var onekalphaEruptions = eruptions.Where(x => x.Year < 1000).Select(x => x.Volcano).Order();
// onekalphaEruptions.ToList().ForEach(System.Console.WriteLine);



// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!

static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
