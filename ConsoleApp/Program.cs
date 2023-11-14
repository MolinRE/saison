using Saison;

var untappd = new Untappd("", "");
var keyword = "zagovor hazy";
Console.WriteLine($"Поиск по \"{keyword}\":");
var result = await untappd.Beer.Search(keyword);
foreach (var beer in result.Response.Beers.Items)
{
    Console.WriteLine($"{beer.Brewery.BreweryName} -- {beer.Beer.BeerName} ({beer.Beer.Bid})");
}

var breweryInfo = await untappd.Brewery.InfoAsync(result.Response.Beers.Items.First().Brewery.BreweryId);
Console.WriteLine(breweryInfo.Response.Brewery.BreweryName);
Console.WriteLine(breweryInfo.Response.Brewery.BreweryDescription);

var brewerySearchInfo = await untappd.Brewery.Search("mitra");
foreach (var brewerySearch in brewerySearchInfo.Response.Result.Items)
{
    Console.WriteLine($"{brewerySearch.Item.Id}. {brewerySearch.Item.Name} ({brewerySearch.Item.CountryName})");
}

var checkins = await untappd.Brewery.Checkins(478818);
foreach (var checkin in checkins.Response.Checkins.Items)
{
    Console.WriteLine($"{checkin.User.UserName}: {checkin.Brewery.BreweryName} -- {checkin.Beer.BeerName}");
}