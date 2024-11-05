namespace MusicWebApp.Common
{
    public static class EntityValidationConstants
    {
        public static class Artist
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 30;

            public const int DescriptionMinLength = 30;
            public const int DescriptionMaxLength = 5000;

            public const int ImageUrlMinLength = 5;
            public const int ImageUrlMaxLength = 70;

        }
    }
}
