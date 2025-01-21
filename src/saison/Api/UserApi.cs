using Saison.Extensions;
using Saison.Models.Untappd;
using Saison.Models.User.Wishlist;
using System.Text;
using System.Threading.Tasks;

namespace Saison.Api;

public class UserApi
{
    private readonly ServiceClientAsync _serviceClient;

    public UserApi()
    {
        _serviceClient = new();
    }
    
    public async Task<ResponseContainer<WishlistAction>> WishlistAdd(int bid, string accessToken)
    {
        var builder = new StringBuilder($"/v4/user/wishlist/add?bid={bid}&access_token={accessToken}");

        return await _serviceClient.ExecuteGetAsync<ResponseContainer<WishlistAction>>(builder.ToString());
    }
    
    public async Task<ResponseContainer<WishlistAction>> WishlistRemove(int bid, string accessToken)
    {
        var builder = new StringBuilder($"/v4/user/wishlist/delete?bid={bid}&access_token={accessToken}");

        return await _serviceClient.ExecuteGetAsync<ResponseContainer<WishlistAction>>(builder.ToString());
    }
    
    public async Task<ResponseContainer<UserWishlist>> UserWishlist(
        string userName,
        int? offset = 0,
        int limit = 25,
        WishlistSorting sorting = WishlistSorting.date,
        string? accessToken = null)
    {
        var builder = new StringBuilder($"/v4/user/wishlist/{userName}?offset={offset}&limit={limit}&sorting={sorting}");
        builder.AppendAccessToken(accessToken);

        return await _serviceClient.ExecuteGetAsync<ResponseContainer<UserWishlist>>(builder.ToString());
    }
}