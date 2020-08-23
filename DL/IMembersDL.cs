<<<<<<< HEAD
﻿using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DL
{
    public interface IMembersDL
    {
        Members GetMember(string Email, string Password);
        ConfirmationCode SendPassword(string Email, SendPassword Source);
        Members PostMember(Members Member);
        Boolean PutMember(Members Member);
        Boolean DeleteMember(int ID);
    }
}
=======
﻿using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DL
{
    public interface IMembersDL
    {
        Members GetMember(string Email, string Password);
        ConfirmationCode SendPassword(string Email, SendPassword Source);
        Members PostMember(Members Member);
        Boolean PutMember(Members Member);
        Boolean DeleteMember(int ID);
    }
}
>>>>>>> 2e2e904e19a3352cd931c8042a350f402bffd019
