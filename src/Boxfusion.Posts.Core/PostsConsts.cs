using Boxfusion.Posts.Debugging;

namespace Boxfusion.Posts
{
    public class PostsConsts
    {
        public const string LocalizationSourceName = "Posts";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "80524a928cb3414e85369253b80cbda6";
    }
}
