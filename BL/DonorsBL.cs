<<<<<<< HEAD
﻿using DL;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class DonorsBL : IDonorsBL
    {
        IDonorsDL _IDonorsDL;
        public DonorsBL(IDonorsDL DonorsDL)
        {
            _IDonorsDL = DonorsDL;
        }

        public List<DonorsList> GetAllDonors()
        {
            return _IDonorsDL.GetAllDonors();
        }

        public Boolean PostDonor(Donors Donor)
        {
            return _IDonorsDL.PostDonor(Donor);
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
    public class DonorsBL : IDonorsBL
    {
        IDonorsDL _IDonorsDL;
        public DonorsBL(IDonorsDL DonorsDL)
        {
            _IDonorsDL = DonorsDL;
        }

        public List<DonorsList> GetAllDonors()
        {
            return _IDonorsDL.GetAllDonors();
        }

        public Boolean PostDonor(Donors Donor)
        {
            return _IDonorsDL.PostDonor(Donor);
        }
    }
}
>>>>>>> 2e2e904e19a3352cd931c8042a350f402bffd019
