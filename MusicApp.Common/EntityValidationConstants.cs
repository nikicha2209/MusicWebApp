using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Common
{
    public static class EntityValidationConstants
    {
        public static class Song
        {
            public const int TitleMinLength = 3;
            public const int TitleMaxLength = 200;

            public const string DurationMinValue = "00:00:01";
            public const string DurationMaxValue = "24:00:00";

            public const int SpotifyIdMaxLength = 22;
        }

        public static class Artist
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 30;

            public const int BiographyMinLength = 30;
            public const int BiographyMaxLength = 1000;

            public const int ImageUrlMinLength = 5;
            public const int ImageUrlMaxLength = 70;

            public const int SpotifyIdMaxLength = 22;
        }
    }
}
