using System.Text;

namespace Saison.Extensions;

public static class StringBuilderExtensions
{
    public static StringBuilder AppendAccessToken(this StringBuilder builder, string? accessToken = null)
    {
        if (accessToken != null)
        {
            builder.Append($"&access_token={accessToken}");
        }

        return builder;
    }
}