# saison

.NET Core Untappd Client

![Nuget](https://img.shields.io/nuget/v/Saison)
![Nuget](https://img.shields.io/nuget/dt/Saison)

## How to install

Install [Saison](https://www.nuget.org/packages/Saison) from NuGet:

```
> dotnet add package Saison
```

## How to use

Register on [untappd.com](https://untappd.com) and apply for API key. Next:

```c#
using Saison;

var client = new Untappd("clientId", "clientSecret");
// Search for beer
await client.Beer.Search("punk ipa");
// Get beer info
await client.Beer.Info(2819207);
// Get local activity
await client.ThePub.Local(55.762611, 37.58996);
```

Checkins and more POST-methods coming soon.

## API coverage

### Feeds

- Activity Feed
- User Activity Feed
- ✅ The Pub (Local)
- ✅ Venue Activity Feed
- ✅ Beer Activity Feed
- ✅ Brewery Activity Feed
- Notifications

### Info / Search

- User Info
- User Wish List
- User Friends
- User Badges
- User Beers
- ✅ Brewery Info
- ✅ Beer Info
- ✅ Venue Info
- ✅ Beer Search
- ✅ Brewery Search

### Actions

- Checkin
- Toast / Un-toast
- Pending Friends
- Add Friend
- Remove Friend
- Accept Friend
- Reject Friend
- Add Comment
- Remove Comment
- Add to Wish List
- Remove from Wish List

### Utilities

- ✅ Foursquare Lookup
