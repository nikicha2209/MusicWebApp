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
            public const int ImageUrlMaxLength = 70;
        }

        public static class Song
        {
            public const int TitleMinLength = 3;
            public const int TitleMaxLength = 200;

            public const string DurationMinValue = "00:00:01";
            public const string DurationMaxValue = "24:00:00";

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
