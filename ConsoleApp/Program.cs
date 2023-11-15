using Saison;
using Saison.Models;

var untappd = new Untappd("EF96C27252F10B97790F518DECEFFC69191A0B95", "70C1D3751F90F7996B9209048577240B3B1B5FF1");

// var keyword = "zagovor hazy";
// Console.WriteLine($"Поиск по \"{keyword}\":");
// var result = await untappd.Beer.Search(keyword);
// foreach (var beer in result.Response.Beers.Items)
// {
//     Console.WriteLine($"{beer.Brewery.BreweryName} -- {beer.Beer.BeerName} ({beer.Beer.Bid})");
// }


var beerInfo = await untappd.Beer.GetInfo(-1);
try
{
    untappd.Venue.LookupFoursquare("");
    Console.WriteLine($"{beerInfo.Response.Beer.BeerName} -- {beerInfo.Response.Beer.Brewery.BreweryName}");
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}

//
// var breweryInfo = await untappd.Brewery.InfoAsync(result.Response.Beers.Items.First().Brewery.BreweryId);
// Console.WriteLine(breweryInfo.Response.Brewery.BreweryName);
// Console.WriteLine(breweryInfo.Response.Brewery.BreweryDescription);
//
// var brewerySearchInfo = await untappd.Brewery.Search("mitra");
// foreach (var brewerySearch in brewerySearchInfo.Response.Result.Items)
// {
//     Console.WriteLine($"{brewerySearch.Item.Id}. {brewerySearch.Item.Name} ({brewerySearch.Item.CountryName})");
// }
//
// var checkins = await untappd.Brewery.Checkins(478818);
// foreach (var checkin in checkins.Response.Checkins.Items)
// {
//     Console.WriteLine($"{checkin.User.UserName}: {checkin.Brewery.BreweryName} -- {checkin.Beer.BeerName}");
// }

// var pubInfo = await untappd.ThePub.Local(55.869117f, 37.473959f, distancePreference: DistancePreference.Kilometers);
// Console.WriteLine($"ThePub:");
// foreach (var pub in pubInfo.Response.Checkins.Items)
// {
//     Console.WriteLine($"[{pub.CreatedAt}]: {pub.User.UserName} drinks \"{pub.Beer.BeerName}\" at {pub.Venue.VenueName}");
// }
//
// await untappd.Venue.FoursquareLookup()