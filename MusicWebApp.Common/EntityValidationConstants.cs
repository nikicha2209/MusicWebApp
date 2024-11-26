namespace MusicWebApp.Common
{
    public static class EntityValidationConstants
    {
        public static class Artist
        {
            public const int NameMinLength = 2; // Кратки имена като "Ed"
            public const int NameMaxLength = 255; // Максимум за текстови полета

            public const int DescriptionMinLength = 10; // Основно описание
            public const int DescriptionMaxLength = 5000; // Подробно описание

            public const int ImageUrlMinLength = 5; // Най-кратък валиден URL (пример: "a.co")
            public const int ImageUrlMaxLength = 2083; // Ограничението за URL в браузъри

            public const int YouTubeChannelTitleMinLength = 1; // Еднобуквени имена
            public const int YouTubeChannelTitleMaxLength = 100; // Максимум в YouTube
        }

        public static class Song
        {
            public const int TitleMinLength = 1;
            public const int TitleMaxLength = 200;

            public const string DurationMinValue = "00:00:01";
            public const string DurationMaxValue = "24:00:00";

            public const int YoutubeVideoIdMinLength = 11; // винаги 11 символа
            public const int YouTubeVideoIdMaxLength = 11;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 500;

            public const int ThumbnailUrlMinLength = 5;
            public const int ThumbnailUrlMaxLength = 2083;

            public const int YouTubeUrlMaxLength = 2083;
        }

        public static class Album
        {
            public const int TitleMinLength = 1; 
            public const int TitleMaxLength = 255; 

            public const int ImageUrlMinLength = 5; 
            public const int ImageUrlMaxLength = 2083; 
        }
    }
}
