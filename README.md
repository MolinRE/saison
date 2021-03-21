# saison
.NET Core Untappd Client

## How to use

```c#
using Saison;

var client = new Untappd("clientId", "clientSecret");
// Search for beer
client.Beer.Search("punk ipa");
// Get beer info
client.Beer.Info(2819207);
// Get local activity
client.ThePub.Local(55.762611, 37.58996);
```

Checkins and more POST-methods coming soon.