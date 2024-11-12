namespace MusicWebApp.Common
{
    public static class EntityValidationConstants
    {
        public static class Artist
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 30;

            public const int DescriptionMinLength = 30;
            public const int DescriptionMaxLength = 2000;

            public const int ImageUrlMinLength = 5;
            public const int ImageUrlMaxLength = 2048;

            public const int YouTubeChannelTitleMinLength = 1;
            public const int YouTubeChannelTitleMaxLength = 100;

        }

        public static class Song
        {
            public const int TitleMinLength = 3;
            public const int TitleMaxLength = 200;

            public const string DurationMinValue = "00:00:01";
            public const string DurationMaxValue = "24:00:00";

            public const int YoutubeVideoIdMinLength = 11;
            public const int YouTubeVideoIdMaxLength = 100;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 500;

            public const int ThumbnailUrlMinLength = 10;
            public const int ThumbnailUrlMaxLength = 2048;

            public const int YouTubeUrlMaxLength = 200;
        }

        public static class Álbum
        {
            public const int TitleMinLength = 3;
            public const int TitleMaxLength = 30;

            public const int ImageUrlMinLength = 5;
            public const int ImageUrlMaxLength = 70;
        }
    }
}
