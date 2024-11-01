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
        }

        
    }
}
