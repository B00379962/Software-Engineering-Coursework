﻿using System.Collections.Generic;


namespace DataAccessManager
{
    public class AdminUserShop2 : IUser
    {
        public List<string> Users()
        {
            return new List<string> { "Davie Walker" };
        }
    }
}
