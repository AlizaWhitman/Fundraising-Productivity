<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class ConfirmationCode
    {
        public Status EmailStatus { get; set; }
        public string Code { get; set; }
        
    }

    public enum Status
    {
        EmailSent = 1,
        ProblemSending = 2,
        EmailNotFound = 3,
        IncorrectFormat = 4,
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class ConfirmationCode
    {
        public Status EmailStatus { get; set; }
        public string Code { get; set; }
        
    }

    public enum Status
    {
        EmailSent = 1,
        ProblemSending = 2,
        EmailNotFound = 3,
        IncorrectFormat = 4,
    }
}
>>>>>>> 2e2e904e19a3352cd931c8042a350f402bffd019
