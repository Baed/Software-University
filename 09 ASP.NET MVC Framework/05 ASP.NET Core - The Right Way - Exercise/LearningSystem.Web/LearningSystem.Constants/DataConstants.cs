using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Constants
{
    public class DataConstants
    {
        public const int ARTICLE_TITLE_MIN_LENGTH = 3;
        public const int ARTICLE_TITLE_MAX_LENGTH = 50;

        public const int USER_NAME_MIN_LENGTH = 2;
        public const int USER_NAME_MAX_LENGTH = 80;

        public const int COURSE_NAME_MIN_LENGTH = 2;
        public const int COURSE_NAME_MAX_LENGTH = 50;
        public const int COURSE_DESCRIPTION_MAX_LENGTH = 3000;

        public const int COURSE_EXAM_SUBMISSION_FILE_LENGTH = 2 * 1024 * 1024;
    }
}
