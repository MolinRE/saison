using System.Text;

namespace Saison.Extensions;

internal static class StringBuilderExtensions
{
    internal static StringBuilder AppendAccessToken(this StringBuilder builder, string? accessToken = null)
    {
        if (accessToken != null)
        {
            builder.Append($"&access_token={accessToken}");
        }

        return builder;
    }
}