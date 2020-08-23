<<<<<<< HEAD
﻿using DL;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class CallsSummaryBL:ICallsSummaryBL
    {
        ICallsSummaryDL _ICallsSummaryDL;
        public CallsSummaryBL(ICallsSummaryDL ICallsSummaryDL)
        {
            _ICallsSummaryDL = ICallsSummaryDL;
        }
        public void PostCallsSummary(CallsSummary cs)
        {
            cs.TimeDate = DateTime.Now.ToString();
            _ICallsSummaryDL.PostCallsSummary(cs);
        }

    }
}
=======
﻿using DL;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class CallsSummaryBL:ICallsSummaryBL
    {
        ICallsSummaryDL _ICallsSummaryDL;
        public CallsSummaryBL(ICallsSummaryDL ICallsSummaryDL)
        {
            _ICallsSummaryDL = ICallsSummaryDL;
        }
        public void PostCallsSummary(CallsSummary cs)
        {
            cs.TimeDate = DateTime.Now.ToString();
            _ICallsSummaryDL.PostCallsSummary(cs);
        }

    }
}
>>>>>>> 2e2e904e19a3352cd931c8042a350f402bffd019
